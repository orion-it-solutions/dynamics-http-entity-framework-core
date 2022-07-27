using Dynamics.Http.EntityFrameworkCore.Extensions;
using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Context;
using Dynamics.Http.EntityFrameworkCore.Persistences;
using Dynamics.Http.EntityFrameworkCore.UT.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dynamics.Http.EntityFrameworkCore.UT
{
    [TestClass]
    public class UnitTest1
    {
        private DynamicsDataContext _context;

        [TestMethod]
        public void TestMethod1()
        {
            DynamicsContextOptions options = new DynamicsContextOptions();
            options.Connection.TenantId = "346a1d1d-e75b-4753-902b-74ed60ae77a1";
            options.Connection.ClientId = "5f32110f-cf6e-4557-9e40-391ff6870b12";
            options.Connection.ClientSecret = "-~E1gn3-40G7ZDu_jdzD68~Uyb~U9CB~7s";
            options.Connection.GrantType = "client_credentials";
            options.Connection.AuthorityUrl = "https://login.microsoftonline.com/346a1d1d-e75b-4753-902b-74ed60ae77a1";
            options.Connection.Resource = "https://latammx-caeuvmdesarrollo.crm.dynamics.com";
            options.Connection.Version = "9.2";
            
            options.AddEntityDeffinition<Contact>();
            _context = new DynamicsDataContext(options);

            var contactEntity = _context.Set<Contact>();
            var contacts = _context.Set<Contact>().RetriveMultiple();
            var contact = _context.Set<Contact>().Retrive(Guid.NewGuid());
            var createdStatus = _context.Set<Contact>().Create(new Contact());
            var updatedStatus = _context.Set<Contact>().Update(new Contact());
            var deletedStatus = _context.Set<Contact>().Delete(new Contact());
        }
    }
}