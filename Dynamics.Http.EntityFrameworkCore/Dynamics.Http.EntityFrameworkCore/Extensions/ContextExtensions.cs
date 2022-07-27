using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Extensions
{
    public static class ContextExtensions
    {
        public static IEnumerable<TEntity> ToList<TEntity>(this DynamicsEntitySet<TEntity> entitySet) where TEntity : class
        {
            return entitySet.ToList();
        }

        public static void ConvertToCustomEntityModel()
        {

        }
    }
}
