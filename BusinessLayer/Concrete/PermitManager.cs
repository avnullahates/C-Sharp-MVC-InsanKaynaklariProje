using BusinessLayer.Abstract;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PermitManager : IPermitService
    {
        private readonly IPermitDal permitDal;

        public PermitManager(IPermitDal permitDal)
        {
            this.permitDal = permitDal;
        }

        public List<Permit> GetListAllPermit(string id)
        {
            return permitDal.GetListAllPermit(id);
        }
    }
}
