using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheExpense.Models;

namespace TheExpense.DAL.Interfaces
{
    public interface IPayerRepository
    {
        void InsertPayer(Payer Entity);
        void DeletePayer(int ID);
        void UpdatePayer(Payer Entity);

        IEnumerable<Payer> GetPayers();
        Payer GetPayerByID(int ID);

    }
}
