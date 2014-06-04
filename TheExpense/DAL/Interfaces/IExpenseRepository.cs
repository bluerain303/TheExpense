using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheExpense.Models;

namespace TheExpense.DAL.Interfaces
{
    public interface IExpenseRepository
    {
        void InsertExpense(Expense Entity);
        void DeleteExpense(int ID);
        void UpdateExpense(Expense Entity);

        IEnumerable<Expense> GetExpenses();
        Expense GetExpenseByID(int ID);

    }
}
