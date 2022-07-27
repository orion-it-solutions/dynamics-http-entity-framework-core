using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Data
{
    public class DynamicsEntitySet<TEntity> where TEntity : class
    {
        private TEntity? _entity;

        private Guid _entitySetId;

        public DynamicsEntitySet()
        {
            _entitySetId = Guid.NewGuid();
            _entity = (TEntity?)Activator.CreateInstance(typeof(TEntity));
        }

        public TEntity? Entity { get => _entity; }

        public Guid EntitySetId { get => _entitySetId; }

        public TEntity Retrive(Guid id)
        {
            return (TEntity)Activator.CreateInstance(typeof(TEntity));
        }

        public ICollection<TEntity> RetriveMultiple()
        {
            return new HashSet<TEntity>();
        }

        public bool Create<TEntity>(TEntity entity) where TEntity : class, new()
        {
            return false;
        }

        public bool Update<TEntity>(TEntity entity) where TEntity : class, new()
        {
            return false;
        }

        public bool Update<TEntity>(Guid id, TEntity entity) where TEntity : class, new()
        {
            return false;
        }

        public bool Delete<TEntity>(TEntity entity) where TEntity : class, new()
        {
            return false;
        }

        public static bool Delete<TEntity>(Guid id) where TEntity : class, new()
        {
            return false;
        }
    }
}
