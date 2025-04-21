using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAccountReconciliationDetailDal : EfEntityRepositoryBase<AccountReconciliationDetail, ContextDb>, IAccountReconciliationDetailDal
    {
    }
}
