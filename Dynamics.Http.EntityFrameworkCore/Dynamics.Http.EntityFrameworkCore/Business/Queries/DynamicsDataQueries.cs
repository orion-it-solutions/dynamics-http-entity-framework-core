using Dynamics.Http.EntityFrameworkCore.Business.Configurations;
using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Context;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Business.Queries
{
    internal class DynamicsDataQueries : DynamicsConnectionConfiguration
    {
        public DynamicsDataQueries(DynamicsContextOptions options) : base(options) { }

        public JArray RetriveMultiple()
        {
            return null;
        }

        public JObject Retrive()
        {
            return null;
        }
    }
}
