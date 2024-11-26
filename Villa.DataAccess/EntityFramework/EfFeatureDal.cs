﻿using MongoDB.Driver.Core.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;

namespace Villa.DataAccess.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature> , IFeatureDal
    {
        public EfFeatureDal(VillaContext context) : base(context)
        {
        }
    }
}
