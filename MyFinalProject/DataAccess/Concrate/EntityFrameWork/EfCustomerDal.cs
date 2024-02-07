﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFrameWork
{
    internal class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>,ICustomerDal
    {
    }
}
