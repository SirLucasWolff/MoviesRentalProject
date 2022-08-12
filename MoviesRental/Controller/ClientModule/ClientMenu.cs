using MoviesRental.Domain.ClientModule;
using RentalMovies.Screen.ClientModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.ClientModule
{
    public class ClientMenu
    {
        ClientScreen clientScreen = new ClientScreen();

        ClientController clientController = new ClientController();

        Client client = new Client();

        public MainController ClientOptions()
        {
            clientScreen.ClientMenu();

            int ClientOption = Convert.ToInt32(Console.ReadLine());

            switch (ClientOption)
            {
                case 1:
                    clientController.AddClient(client);
                    break;
                case 2:
                    clientController.DeleteClient(client.Id);
                    break;
                case 3:
                    clientController.EditClient(client.Id, client);
                    break;
                case 4:
                    clientController.ShowClients();
                    Console.ReadLine();
                    break;
                case 5:
                    break;
            }

            return new MainController();
        }
    }
}
