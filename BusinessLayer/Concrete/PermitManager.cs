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
         IPermitDal _permitDal;

        public PermitManager(IPermitDal permitDal)
        {
            
            _permitDal = permitDal;
        }

        public List<Permit> GetListAllPermit(string id)
        {
            return _permitDal.GetListAllPermit(id);
        }
        public bool Approved(int id)
        {
            return _permitDal.Approved(id);
        }
        public bool Rejected(int id)
        {
            return _permitDal.Rejected(id);
        }

        public List<Permit> GetListAllPermit()
        {
            return _permitDal.GetListAll();
        }

        public List<Permit> GetAllPermitWithPersonnel()
        {
            return _permitDal.GetAllPermitWithPersonnel();
        }
    }
}
