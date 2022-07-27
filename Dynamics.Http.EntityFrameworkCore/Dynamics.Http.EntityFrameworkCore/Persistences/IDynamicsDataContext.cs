using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Persistences
{
    public interface IDynamicsDataContext
    {
        //DynamicsEntitySet<TEntity> Set<TEntity>() where TEntity : class;

        //Task<IEnumerable<TEntity>> RetriveMultiple<TEntity>() where TEntity : class, new();

        DynamicsEntitySet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
