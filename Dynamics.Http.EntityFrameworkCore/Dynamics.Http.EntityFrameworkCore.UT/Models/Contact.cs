using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamics.Http.EntityFrameworkCore.Infrastructure.AnnotationAttributes.Entities;
using Dynamics.Http.EntityFrameworkCore.Infrastructure.AnnotationAttributes.Fields;
using static Dynamics.Http.EntityFrameworkCore.Infrastructure.AnnotationAttributes.Fields.IFieldAttribute;

namespace Dynamics.Http.EntityFrameworkCore.UT.Models
{
    
    [EntityAttribute("contact", "contacts")]
    public class Contact
    {
        [FieldAttribute("contactId", "contactid", FieldTypes.EntityUniqueIdentifier)]
        public Guid Id { get; set; }
    }
}
