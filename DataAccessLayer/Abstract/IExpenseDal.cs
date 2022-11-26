using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IExpenseDal:IGENERICDAL<Expense>
    {
        List<Expense> GetListAllExpense(string id);
        bool Approved(int id);
        bool Rejected(int id);
        List<Expense> GetAllExpenseWithPersonnel();
    }
}
