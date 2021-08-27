using Microsoft.EntityFrameworkCore;
using System;

namespace ProductOrdering.Data.UnitOfWork
{
    public static class UnitOfWorkExtensions
    {
        public static TDbContext GetDbContext<TDbContext>(this IUnitOfWork unitOfWork)
            where TDbContext : DbContext
        {
            if (unitOfWork == null) {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            if (!(unitOfWork is EfCoreUnitOfWork)) {
                throw new ArgumentException("unitOfWork is not type of " + typeof(EfCoreUnitOfWork).FullName, nameof(unitOfWork));
            }

            return (unitOfWork as EfCoreUnitOfWork).GetOrCreateDbContext<TDbContext>();
        }

    }
}