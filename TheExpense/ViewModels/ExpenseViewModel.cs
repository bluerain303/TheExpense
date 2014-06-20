using Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheExpense.Models;

namespace TheExpense.ViewModels
{
    public class ExpenseViewModel
    {
        #region Constructors
        // ######################################################
        public ExpenseViewModel() { }

        public ExpenseViewModel(Expense Exp)
        {
            this.Id = Exp.ID;
            //this.PayerId = Exp.PayerID;
            //this.PayeeId = Exp.PayeeID;
            this.Amount = Exp.Amount;
            this.Currency = Exp.Currency;
            this.Comment = Exp.Comment;
        }
        // ######################################################
        #endregion

        #region Properties
        // ######################################################
        [JqGridColumnEditable(false)]
        public int Id { get; set; }
         [JqGridColumnEditable(false)]
        public int PayerId { get; set; }
         [JqGridColumnEditable(false)]
        public int PayeeId { get; set; }
         [JqGridColumnEditable(false)]
        public DateTime Date { get; set; }
         [JqGridColumnEditable(false)]
        public decimal Amount { get; set; }
         [JqGridColumnEditable(false)]
        public string Currency { get; set; }
         [JqGridColumnEditable(true)]
        public string Comment { get; set; }
        // ######################################################
        #endregion
    }
}