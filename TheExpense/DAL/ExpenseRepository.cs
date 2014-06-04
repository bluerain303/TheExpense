using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheExpense.DAL.Interfaces;
using TheExpense.Models;

namespace TheExpense.DAL
{
    public class ExpenseRepository : IExpenseRepository
    {
        private TheExpenseDbContext _context;

        #region Constructors
        // ######################################################
        public ExpenseRepository(TheExpenseDbContext Context)
        {
            this._context = Context;
        }
        // ######################################################
        #endregion

        #region IExpenseRepository member
        // ######################################################
        public void InsertExpense(Models.Expense Entity)
        {
            this._context.Expenses.Add(Entity);
        }

        public void DeleteExpense(int ID)
        {
            Expense entity = this._context.Expenses.Find(ID);
            if (entity != null)
            {
                this._context.Expenses.Remove(entity);
            }
        }

        public void UpdateExpense(Models.Expense Entity)
        {
            this._context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IEnumerable<Models.Expense> GetExpenses()
        {
            return this._context.Expenses.ToList();
        }

        public Models.Expense GetExpenseByID(int ID)
        {
            return this._context.Expenses.Find(ID);
        }

        // ######################################################
        #endregion
    }
}