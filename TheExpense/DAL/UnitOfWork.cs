using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheExpense.DAL.Interfaces;

namespace TheExpense.DAL
{
    public class UnitOfWork : IDisposable
    {
        private TheExpenseDbContext _context;
        private IPayerRepository _payerRepository;
        private IPayeeRepository _payeeRepository;
        private IExpenseRepository _expenseRepository;

        private bool _disposed = false;

        #region Constructors
        // ######################################################
        public UnitOfWork()
        {
            this._context = new TheExpenseDbContext();
        }

        public UnitOfWork(IPayerRepository PayerRepository)
        {
            this._payerRepository = PayerRepository;
        }

        public UnitOfWork(IPayeeRepository PayeeRepository)
        {
            this._payeeRepository = PayeeRepository;
        }

        public UnitOfWork(IExpenseRepository ExpenseRepository)
        {
            this._expenseRepository = ExpenseRepository;
        }
        // ######################################################
        #endregion

        #region Properties
        // ######################################################
        public IPayerRepository PayerRepository
        { 
            get
            {
                if (this._payerRepository == null)
                {
                    this._payerRepository = new PayerRepository(this._context);
                }
                return this._payerRepository;
            }
        }

        public IPayeeRepository PayeeRepository
        {
            get
            {
                if (this._payeeRepository == null)
                {
                    this._payeeRepository = new PayeeRepository(this._context);
                }
                return this._payeeRepository;
            }
        }

        public IExpenseRepository ExpenseRepository
        {
            get
            {
                if (this._expenseRepository == null)
                {
                    this._expenseRepository = new ExpenseRepository(this._context);
                }
                return this._expenseRepository;
            }
        }
        // ######################################################
        #endregion


        public void Save()
        {
            this._context.SaveChanges();
        }


        #region IDisposable member
        // ######################################################
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        // ######################################################
        #endregion

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }
            this._disposed = true;
        }

    }
}