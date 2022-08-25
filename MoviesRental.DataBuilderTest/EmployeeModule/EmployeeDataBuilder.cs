using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesRental.Domain.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.DataBuilderTest.EmployeeModule
{
    [TestClass]
    public class EmployeeDataBuilder
    {
        private Employee employee;

        public Employee Build()
        {
            return employee;
        }

        public EmployeeDataBuilder()
        {
            employee = new Employee();
        }

        public EmployeeDataBuilder WithEmail(string email)
        {
            employee.Email = email;
            return this;
        }

        public EmployeeDataBuilder WithName(string name)
        {
            employee.Name = name;
            return this;
        }

        public EmployeeDataBuilder WithPassword(string password)
        {
            employee.Password = password;
            return this;
        }

        public EmployeeDataBuilder WithAccessKey(string key)
        {
            employee.AccessKey = key;
            return this;
        }

        public Employee GenerateCompleteEmployee()
        {
            return this.WithAccessKey("testName")
                .WithEmail("testName")
                .WithName("TestName")
                .WithPassword("TestName").Build();
        }
    }
}
