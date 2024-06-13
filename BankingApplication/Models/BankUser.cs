using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BankingApplication.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class BankUser
    {
        [Key]
        public int UserId { get; set; }
        public string EmailAddress {  get; set; }
        public string Password { get; set; }

        //One user may have many accounts
        public ICollection<BankAccount> UserAccounts { get; } = new List<BankAccount>();

    }
}
