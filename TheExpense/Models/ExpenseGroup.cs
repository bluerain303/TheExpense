using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace TheExpense.Models
{
    public class ExpenseGroup
    {
        public int ID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int FullName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Comment
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
