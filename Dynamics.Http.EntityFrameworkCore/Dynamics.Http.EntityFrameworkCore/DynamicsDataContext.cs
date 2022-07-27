using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Context;
using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Data;
using Dynamics.Http.EntityFrameworkCore.Persistences;

namespace Dynamics.Http.EntityFrameworkCore
{
    public class DynamicsDataContext : IDynamicsDataContext
    {
        private readonly Guid _contextId = Guid.NewGuid();

        private readonly DynamicsContextOptions _options;

        public DynamicsDataContext() { }

        public DynamicsDataContext(DynamicsContextOptions options)
        {
            if(options is null)
                throw new ArgumentNullException(nameof(options));
            _options = options;
        }

        public DynamicsContextOptions ContextOptions { get => _options; }
 
        public virtual DynamicsEntitySet<TEntity> Set<TEntity>() 
            where TEntity : class
        {
            var entityBuilder = _options.EntitiesBuilder.FirstOrDefault(x => x.EntityType == typeof(TEntity));
            if (entityBuilder is null)
                throw new NotImplementedException($"The entity type '{ typeof(TEntity).Name }' was not configured in context.");
            return (DynamicsEntitySet<TEntity>)Activator.CreateInstance(typeof(DynamicsEntitySet<TEntity>));
        }

        //public async Task<IEnumerable<TEntity>> RetriveMultiple<TEntity>() where TEntity : class, new()
        //{
        //    return new List<TEntity>();
        //}
    }
}