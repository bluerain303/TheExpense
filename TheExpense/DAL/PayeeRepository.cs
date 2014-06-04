using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheExpense.DAL.Interfaces;
using TheExpense.Models;

namespace TheExpense.DAL
{
    public class PayeeRepository : IPayeeRepository //, IDisposable
    {
        private TheExpenseDbContext _context;
        //private bool _disposed = false;

        #region Constructors
        // ######################################################
        public PayeeRepository(TheExpenseDbContext Context)
        {
            this._context = Context;
        }
        // ######################################################
        #endregion


        #region IPayeeRepository members
        // ######################################################
        public void InsertPayee(Models.Payee Entity)
        {
            this._context.Payees.Add(Entity);
        }

        public void DeletePayee(int ID)
        {
            Payee entity = this._context.Payees.Find(ID);
            if (entity != null)
            {
                this._context.Payees.Remove(entity);
            }
        }

        public void UpdatePayee(Models.Payee Entity)
        {
            this._context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IEnumerable<Models.Payee> GetPayees()
        {
            return this._context.Payees.ToList();
        }

        public Models.Payee GetPayeeByID(int ID)
        {
            return this._context.Payees.Find(ID);
        }
        // ######################################################
        #endregion


        #region IDisposable member
        // ######################################################
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
        // ######################################################
        #endregion

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this._disposed)
        //    {
        //        if (disposing)
        //        {
        //            this._context.Dispose();
        //        }
        //    }
        //    this._disposed = true;
        //}
    
    }
}