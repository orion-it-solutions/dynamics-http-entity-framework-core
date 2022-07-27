using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Connection;
using Dynamics.Http.EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Context
{
    public class DynamicsContextOptions
    {
        private readonly DynamicsConnection _connection = new DynamicsConnection();

        private ICollection<EntityBuilder> _entities = new HashSet<EntityBuilder>();

        public DynamicsContextOptions() { }

        public DynamicsContextOptions(DynamicsConnection connection)
        {
            _connection = connection;
        }

        public DynamicsConnection Connection { get => _connection; }

        internal ICollection<EntityBuilder> EntitiesBuilder { get => _entities; }

        public void AddEntityDeffinition<TEntity>() where TEntity : class
            => _entities.Add(new EntityBuilder(typeof(TEntity)));
    }
}
