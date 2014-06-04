using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TheExpense.Models;

namespace TheExpense.DAL
{
    public class TheExpenseDbContext : DbContext
    {
        public TheExpenseDbContext() : base("TheExpense") { }


        public DbSet<Payer> Payers {get;set;}
        public DbSet<Payee> Payees { get; set; }
        public DbSet<Expense> Expenses { get; set; }


    }
}