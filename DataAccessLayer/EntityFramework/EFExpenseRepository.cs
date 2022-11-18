using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFExpenseRepository : GenericRepository<Expense>, IExpenseDal
    {
        private readonly Context dbContext;

        public EFExpenseRepository(Context dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Expense> GetListAllExpense(string id)
        {
           return dbContext.Expenses.Include(a=>a.personnel).Where(a=>a.PersonnelID==id).ToList();
        }
    }
}
