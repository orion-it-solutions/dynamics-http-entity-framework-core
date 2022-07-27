namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.AnnotationAttributes.Entities
{
    /// <summary>
    /// This class contains the implementation of the custom attributes to use for an entity deffinition.
    /// </summary>
    public class EntityAttribute : Attribute, IEntityAttribute
    {
        public EntityAttribute(string schemaName, string logicalName)
        {
            SchemaName = schemaName;
            LogicalName = logicalName;
        }

        /// <summary>
        /// Get and set schema name of an entity.
        /// </summary>
        public virtual string SchemaName { get; set; }

        /// <summary>
        /// Get and set logical name of an entity.
        /// </summary>
        public virtual string LogicalName { get; set; }
    }
}
