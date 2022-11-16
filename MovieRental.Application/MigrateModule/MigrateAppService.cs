using MovieRental.Application.ClientModule;
using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.MigrateModule
{
    public class MigrateAppService
    {
        ClientRepository clientRepository;

        ClientRepositoryORM clientRepositoryORM;

        public MigrateAppService (ClientRepository clientRepository, ClientRepositoryORM clientRepositoryORM)
        {
            this.clientRepository = clientRepository;
            this.clientRepositoryORM = clientRepositoryORM;
        }

        public bool DatabaseMigrate()
        {
            try
            {
                if (FrameworkConfiguration.FrameworkTypeRead() == "SQLServer")
                {
                    List<Client> allClientsSelected = clientRepository.SelectAll();
                }
                else
                {
                    List<Client> allClientsSelected = clientRepositoryORM.SelectAll();
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
