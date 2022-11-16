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
using MoviesRental.Domain.Shared;
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

namespace MoviesRental.WindowsApp.Shared
{
    public class AutoFacBuilder
    {
        public IContainer Container { get; set; }

        public AutoFacBuilder()
        {
            var Containerbuilder = new ContainerBuilder();

            if (FrameworkConfiguration.FrameworkTypeRead() == "EntityFramework")
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
