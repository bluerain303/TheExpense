namespace TheExpense.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TheExpense.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TheExpense.DAL.TheExpenseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TheExpense.DAL.TheExpenseDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Payers.AddOrUpdate(
            //    p => p.FirstName,
            //    new Payer() { FirstName="Yishi", LastName="Li"}
            //    );

            //context.Payees.AddOrUpdate(
            //   p => p.FirstName,
            //   new Payee() { FirstName = "Ling", LastName = "Shen" }
            //   );

            //context.SaveChanges();

            //var yishi = context.Payers.First();
            //var ling = context.Payees.First();

            //context.Expenses.AddOrUpdate(
            //    new Expense() { 
            //        PayerID = yishi.ID, 
            //        PayeeID=ling.ID, 
            //        Amount=100, 
            //        Currency="SEK", 
            //        Date=DateTime.Now, 
            //        Comment="test payment"}
            //    );

            //context.SaveChanges();
        }
    }
}
