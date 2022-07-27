namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.AnnotationAttributes.Fields
{
    /// <summary>
    /// This class contains the implementation of the custom attributes to use for an entity field deffinition.
    /// </summary>
    public class FieldAttribute : Attribute, IFieldAttribute
    {
        public FieldAttribute(string schemaName, string logicalName, IFieldAttribute.FieldTypes fieldType)
        {
            SchemaName = schemaName;
            LogicalName = logicalName;
            FieldType = fieldType;
        }

        /// <summary>
        /// Get and set entity Schema name.
        /// </summary>
        public virtual string SchemaName { get; set; }

        /// <summary>
        /// Get an set entity Logical schema name.
        /// </summary>
        public virtual string LogicalName { get; set; }

        /// <summary>
        /// Get and set entity field type.
        /// </summary>
        public virtual IFieldAttribute.FieldTypes FieldType { get; set; }
    }
}
