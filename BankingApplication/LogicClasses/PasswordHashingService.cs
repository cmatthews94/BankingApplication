﻿using BankingApplication.Interfaces;
using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankingApplication.LogicClasses
{
    public class PasswordHashingService : IPasswordHashingService
    {


        //salt is the random generated byte array that's added to password hashes
        private const int saltSize = 128 / 8;
        //keysize is the length of the password hash
        private const int keySize = 256 / 8;
        private const int iterations = 10000;
        private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA256;
        private static char Delimiter = ';';


        public string HashPassword(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(saltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, _hashAlgorithmName, keySize);

            return string.Join(Delimiter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));

        }

        public bool VerifyLoginDetails(string passwordHash, string inputPassword)
        {
            var elements = passwordHash.Split(Delimiter);
            var salt = Convert.FromBase64String(elements[0]);
            var hash = Convert.FromBase64String(elements[1]);

            var hashInput = Rfc2898DeriveBytes.Pbkdf2(inputPassword, salt, iterations, _hashAlgorithmName, keySize);
            return CryptographicOperations.FixedTimeEquals(hash, hashInput);
        }

        public bool VerifyIfEmailIsValid(string email)
        {
            string regex = "^[^@\\s]+@[^@\\s]+\\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
    }
}
