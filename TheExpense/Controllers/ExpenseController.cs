using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheExpense.Models;
using TheExpense.DAL;
using Lib.Web.Mvc;
using Lib.Web.Mvc.JQuery.JqGrid;
using TheExpense.ViewModels;

namespace TheExpense.Controllers
{
    public class ExpenseController : Controller
    {
        private TheExpenseDbContext db = new TheExpenseDbContext();

        private UnitOfWork _unitOfWork = new UnitOfWork();

        // ### For grid ###################################################
        public ActionResult GetExpenses()
        {
            JqGridResponse response = new JqGridResponse();
            var expenses = this._unitOfWork.ExpenseRepository.GetExpenses();

            if (expenses != null)
            {
                foreach (var exp in expenses)
                {
                    response.Records.Add(
                        new JqGridRecord<ExpenseViewModel>(
                         exp.ID.ToString(),
                         new ExpenseViewModel(exp)));
                }
            }

            return new JqGridJsonResult() { Data = response };
        }

        public ActionResult AddOrUpdateExpense(Expense Entity)
        {
            if (Entity == null)
            { 
                return new HttpStatusCodeResult(500, "Failed");
            }
            if (Entity.ID <= 0)
            {
                this._unitOfWork.ExpenseRepository.InsertExpense(Entity);
            }
            else
            {
                this._unitOfWork.ExpenseRepository.UpdateExpense(Entity);
            }
            
            this._unitOfWork.Save();

            //return PartialView("_EditPartial", Entity);
            return new HttpStatusCodeResult(200, "Succeeded");
        }

        [HttpGet]
        [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
        public ActionResult GetExpenseToEdit(int id)
        {
            var entity = this._unitOfWork.ExpenseRepository.GetExpenseByID(id);
            if (entity == null)
            {
                return new HttpStatusCodeResult(500, "Failed");
            }

            return PartialView("_EditPartial", entity);
        }
        // ###End of For grid ###################################################














        // GET: /Expense/
        public ActionResult Index()
        {
            //var expenses = db.Expenses.Include(e => e.Payee).Include(e => e.Payer);
            //return View(expenses.ToList());

            return View(new Expense() { PayerID=1, PayeeID=1, Amount=333, Currency="CNY", Date = DateTime.Now});
        }

        // GET: /Expense/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expense expense = db.Expenses.Find(id);
            if (expense == null)
            {
                return HttpNotFound();
            }
            return View(expense);
        }

        // GET: /Expense/Create
        public ActionResult Create()
        {
            ViewBag.PayeeID = new SelectList(db.Payees, "ID", "FirstName");
            ViewBag.PayerID = new SelectList(db.Payers, "ID", "FirstName");
            return View();
        }

        // POST: /Expense/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,PayerID,PayeeID,Amount,Currency,Date,Comment")] Expense expense)
        {
            if (ModelState.IsValid)
            {
                db.Expenses.Add(expense);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PayeeID = new SelectList(db.Payees, "ID", "FirstName", expense.PayeeID);
            ViewBag.PayerID = new SelectList(db.Payers, "ID", "FirstName", expense.PayerID);
            return View(expense);
        }

        // GET: /Expense/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expense expense = db.Expenses.Find(id);
            if (expense == null)
            {
                return HttpNotFound();
            }
            ViewBag.PayeeID = new SelectList(db.Payees, "ID", "FirstName", expense.PayeeID);
            ViewBag.PayerID = new SelectList(db.Payers, "ID", "FirstName", expense.PayerID);
            return View(expense);
        }

        // POST: /Expense/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,PayerID,PayeeID,Amount,Currency,Date,Comment")] Expense expense)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expense).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PayeeID = new SelectList(db.Payees, "ID", "FirstName", expense.PayeeID);
            ViewBag.PayerID = new SelectList(db.Payers, "ID", "FirstName", expense.PayerID);
            return View(expense);
        }

        // GET: /Expense/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expense expense = db.Expenses.Find(id);
            if (expense == null)
            {
                return HttpNotFound();
            }
            return View(expense);
        }

        // POST: /Expense/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expense expense = db.Expenses.Find(id);
            db.Expenses.Remove(expense);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
