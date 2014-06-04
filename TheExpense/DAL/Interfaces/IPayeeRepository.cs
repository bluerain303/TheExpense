using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheExpense.Models;

namespace TheExpense.DAL.Interfaces
{
    public interface IPayeeRepository
    {
        void InsertPayee(Payee Entity);
        void DeletePayee(int ID);
        void UpdatePayee(Payee Entity);

        IEnumerable<Payee> GetPayees();
        Payee GetPayeeByID(int ID);

    }
}
