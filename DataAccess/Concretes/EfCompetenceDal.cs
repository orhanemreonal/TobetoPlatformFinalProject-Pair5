using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfCompetenceDal : EfRepositoryBase<Competence, Guid, TobetoPlatformContext>, ICompetenceDal
    {
        public EfCompetenceDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
