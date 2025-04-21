﻿using Core.DataAccess;
using Core.Entities;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAccountReconciliationDetailDal : IEntityRepository<AccountReconciliationDetail>
    {
    }
}
