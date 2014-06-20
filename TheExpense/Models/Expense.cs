using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheExpense.Models
{
    public class Expense
    {
        public int ID { get; set; }

        //[Required]
        //public int PayerID { get; set; }
        //public Payer Payer { get; set; }

        //public int PayeeID { get; set; }
        //public Payee Payee { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [DataType( DataType.Currency)]
        public string Currency { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public Participant Payer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ParticipantGroup PayerGroup
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Participant Payee
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ParticipantGroup PayeeGroup
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Place Place
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ExpenseType Type
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual ICollection<ExpenseGroupMapping> Groups { get; set; }
    }
}