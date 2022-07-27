using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Provider
{
    public class ServiceProvider
    {
        private readonly ServiceCollection _serviceCollection = new ServiceCollection();

        public static ServiceProvider Instance { get; } = new();

    }
}
