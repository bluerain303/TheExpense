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


        public DbSet<Expense> Expenses { get; set; }


    }
}