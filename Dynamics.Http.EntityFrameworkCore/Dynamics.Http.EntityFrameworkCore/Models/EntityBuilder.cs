using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Models
{
    public class EntityBuilder
    {
        private readonly Type? _entityType;

        public EntityBuilder(Type entityType)
        {
            if(entityType is null)
                throw new ArgumentNullException(nameof(entityType));
            _entityType = entityType;
        }

        public Type EntityType { get => _entityType; }
    }
}
