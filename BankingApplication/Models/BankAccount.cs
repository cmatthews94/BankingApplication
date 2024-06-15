using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApplication.Models
{
    public class BankAccount
    {
        [Key]
        public int AccountNumber { get; set; }
        [Precision(18, 2)]
        public decimal Balance { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public BankUser BankUser { get; set; }
        public ICollection<Transaction> Transactions { get; } = new List<Transaction>();

    }
}
