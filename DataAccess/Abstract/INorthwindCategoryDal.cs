﻿using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface INorthwindCategoryDal:IEntityRepository<NorthwindCategory>
    {
    }
}
