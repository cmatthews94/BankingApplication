﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApplicationInteractionForm
{
    public partial class CreateUserForm : Form
    {
        private readonly IBankUserService _bankUserService;
        private readonly IBankAccountService _bankAccountActions;
        public CreateUserForm(IBankUserService bankUserService, IBankAccountService bankAccountActions)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _bankAccountActions = bankAccountActions;
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (this.EmailInputTextbox != null & this.PasswordInputTextbox.Text != null)
            {
                var newUser = new BankUser()
                {
                    EmailAddress = this.EmailInputTextbox.Text,
                    Password = this.PasswordInputTextbox.Text,
                };
                _bankUserService.AddNewUser(newUser);
                var newAccount = new BankAccount()
                {
                    UserId = newUser.UserId,
                    Balance = 0.00m
                };
                _bankAccountActions.AddNewAccount(newAccount);

                MessageBox.Show("Account Created", "", MessageBoxButtons.OK);
                EmailInputTextbox.Text = "";
                PasswordInputTextbox.Text = "";
            }
            else throw new Exception("email or password field empty");
        }

        private void BacktoLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}