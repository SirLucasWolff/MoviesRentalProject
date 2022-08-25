using Autofac;
using Microsoft.Win32;
using MovieRental.Application.ClientModule;
using MovieRental.Application.EmployeModule;
using MovieRental.Application.MovieModule;
using MovieRental.Application.RentModule;
using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.Infra.ORM;
using MoviesRental.Infra.ORM.ClientModule;
using MoviesRental.Infra.ORM.EmployeeModule;
using MoviesRental.Infra.ORM.MovieModule;
using MoviesRental.Infra.ORM.RentModule;
using MoviesRental.Infra.SQL.ClientModule;
using MoviesRental.Infra.SQL.EmployeeModule;
using MoviesRental.Infra.SQL.MovieModule;
using MoviesRental.Infra.SQL.RentModule;
using MoviesRental.WindowsApp.Features.ClientModule;
using MoviesRental.WindowsApp.Features.EmployeeModule;
using MoviesRental.WindowsApp.Features.MovieModule;
using MoviesRental.WindowsApp.Features.RentModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public static class AutoFacBuilder
    {
        public static IContainer Container { get; set; }
        static AutoFacBuilder()
        {
            var Containerbuilder = new ContainerBuilder();

            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Movies Rental Project");

            string pathName = (string)registryKey.GetValue("FrameworkType");

            if (pathName == "EntityFramework")
            {
                Containerbuilder.RegisterType<MoviesRentalDbContext>().InstancePerLifetimeScope();

                RegisterORM(Containerbuilder);
            }
            else
                RegisterSql(Containerbuilder);

            RegistrarAppService(Containerbuilder);

            RegistraOperacoes(Containerbuilder);

            Container = Containerbuilder.Build();
        }

        private static void RegisterORM(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ClientOrmDAO>().As<ClientRepository>().InstancePerDependency();

            containerBuilder.RegisterType<EmployeeOrmDAO>().As<EmployeeRepository>().InstancePerDependency();

            containerBuilder.RegisterType<MovieOrmDAO>().As<MovieRepository>().InstancePerDependency();

            containerBuilder.RegisterType<RentOrmDAO>().As<RentRepository>().InstancePerDependency();
        }

        private static void RegisterSql(ContainerBuilder containerbuilder)
        {
            containerbuilder.RegisterType<ClientSQL>().As<ClientRepository>().InstancePerDependency();

            containerbuilder.RegisterType<EmployeeSQL>().As<EmployeeRepository>().InstancePerDependency();

            containerbuilder.RegisterType<MovieSQL>().As<MovieRepository>().InstancePerDependency();

            containerbuilder.RegisterType<RentSQL>().As<RentRepository>().InstancePerDependency();
        }

        private static void RegistraOperacoes(ContainerBuilder containerbuilder)
        {
            containerbuilder.RegisterType<ClientOperations>().InstancePerDependency();

            containerbuilder.RegisterType<EmployeeOperations>().InstancePerDependency();

            containerbuilder.RegisterType<MovieOperations>().InstancePerDependency();

            containerbuilder.RegisterType<RentOperations>().InstancePerDependency();
        }

        private static void RegistrarAppService(ContainerBuilder containerbuilder)
        {
            containerbuilder.RegisterType<ClientAppService>().InstancePerDependency();

            containerbuilder.RegisterType<EmployeAppService>().InstancePerDependency();

            containerbuilder.RegisterType<MovieAppService>().InstancePerDependency();

            containerbuilder.RegisterType<RentAppService>().InstancePerDependency();
        }
    }
}
