using BusinessLayer.Abstract;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        private readonly IExpenseDal expenseRepository;

        public ExpenseManager(IExpenseDal expenseRepository)
        {
            this.expenseRepository = expenseRepository;
        }

        public List<Expense> GetListAllExpense(string id)
        {
            return expenseRepository.GetListAllExpense(id);
        }
        public bool Approved(int id)
        {
            return expenseRepository.Approved(id);
        }
        public bool Rejected(int id)
        {
            return expenseRepository.Rejected(id);
        }

        public List<Expense> GetAllExpenseWithPersonnel()
        {
            return expenseRepository.GetAllExpenseWithPersonnel();
        }
    }
}
