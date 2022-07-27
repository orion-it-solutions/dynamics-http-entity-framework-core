using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.EntityFramework.Core.Infrastructure.ContextConfiguration
{
    public class DynamicsContextOptions
    {
        private readonly DynamicsConnection _configuration;

        public DynamicsContextOptions(DynamicsConnection configuration)
        {
            _configuration = configuration;
        }
    }
}
