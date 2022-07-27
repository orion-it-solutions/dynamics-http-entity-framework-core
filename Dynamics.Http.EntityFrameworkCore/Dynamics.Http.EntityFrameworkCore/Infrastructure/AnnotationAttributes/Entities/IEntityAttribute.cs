namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.AnnotationAttributes.Entities
{
    /// <summary>
    /// This interface contains the deffinition of the custom attributes used to define metadata information of an entity.
    /// </summary>
    public interface IEntityAttribute
    {
        /// <summary>
        /// Get and set entity Schema name.
        /// </summary>
        string SchemaName { get; set; }

        /// <summary>
        /// Get an set entity Logical schema name.
        /// </summary>
        string LogicalName { get; set; }
    }
}
