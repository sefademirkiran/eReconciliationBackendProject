using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaBsReconcilitionManager : IBaBsReconcilitionService
    {
        private readonly IBaBsReconcilitionDal _baBsReconcilitionDal;

        public BaBsReconcilitionManager(IBaBsReconcilitionDal baBsReconcilitionDal)
        {
            _baBsReconcilitionDal = baBsReconcilitionDal;
        }
    }
}
