using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheExpense.Models
{
    public class Expense
    {
        public int ID { get; set; }

        [Required]
        public int PayerID { get; set; }
        public Payer Payer { get; set; }

        public int PayeeID { get; set; }
        public Payee Payee { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [DataType( DataType.Currency)]
        public string Currency { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Comment { get; set; }
    }
}