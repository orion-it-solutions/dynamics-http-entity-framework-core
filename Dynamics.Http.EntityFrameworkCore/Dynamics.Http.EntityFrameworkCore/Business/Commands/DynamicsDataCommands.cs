using Dynamics.Http.EntityFrameworkCore.Business.Configurations;
using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Context;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Business.Commands
{
    public class DynamicsDataCommands : DynamicsConnectionConfiguration
    {
        public DynamicsDataCommands(DynamicsContextOptions options) : base(options) { }

        public JObject CreateRecord()
        {
            return null;
        }

        public JObject UpdateRecord()
        {
            return null;
        }

        public JObject DeleteRecord()
        {
            return null;
        }
    }
}
