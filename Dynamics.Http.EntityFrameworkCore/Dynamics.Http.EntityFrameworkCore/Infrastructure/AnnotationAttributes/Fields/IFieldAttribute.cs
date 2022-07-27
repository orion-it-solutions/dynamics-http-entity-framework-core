namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.AnnotationAttributes.Fields
{
    /// <summary>
    /// This interface contains the deffinition of the custom attributes used to define metadata information of an entity attribute.
    /// </summary>
    public interface IFieldAttribute
    {
        enum FieldTypes
        {
            Text,
            Number,
            Lookup,
            DateTime,
            OptionSet,
            BooleanOptionSet,
            EntityUniqueIdentifier
        }

        /// <summary>
        /// Get and set entity Schema name.
        /// </summary>
        string SchemaName { get; set; }

        /// <summary>
        /// Get an set entity Logical schema name.
        /// </summary>
        string LogicalName { get; set; }

        /// <summary>
        /// Get and set entity field type.
        /// </summary>
        FieldTypes FieldType { get; set; }
    }
}
