using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheExpense.DAL.Interfaces;
using TheExpense.Models;

namespace TheExpense.DAL
{
    public class PayerRepository : IPayerRepository//, IDisposable
    {
        private TheExpenseDbContext _context;
        //private bool _disposed = false;

        #region Constructors
        // ######################################################
        public PayerRepository(TheExpenseDbContext Context)
        {
            this._context = Context;
        }
        // ######################################################
        #endregion


        #region IPayerRepository members
        // ######################################################
        public void InsertPayer(Models.Payer Entity)
        {
            this._context.Payers.Add(Entity);
        }

        public void DeletePayer(int ID)
        {
            Payer entity = this._context.Payers.Find(ID);
            if (entity != null)
            {
                this._context.Payers.Remove(entity);
            }
        }

        public void UpdatePayer(Models.Payer Entity)
        {
            this._context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IEnumerable<Models.Payer> GetPayers()
        {
            return this._context.Payers.ToList();
        }

        public Models.Payer GetPayerByID(int ID)
        {
            return this._context.Payers.Find(ID);
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