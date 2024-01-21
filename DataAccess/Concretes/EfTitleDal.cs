using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfTitleDal : EfRepositoryBase<Title, Guid, TobetoPlatformContext>, ITitleDal
    {
        public EfTitleDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
