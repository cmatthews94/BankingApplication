using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        [Precision(18, 2)]
        public decimal TransactionValue { get; set; }

        public BankAccount BankAccount { get; set; }
        [ForeignKey("AccountNumber")]
        public int AccountNumber {  get; set; }


    }
}
