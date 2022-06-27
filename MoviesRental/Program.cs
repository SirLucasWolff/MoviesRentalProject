using MoviesRental.DataBase;
using RentalMovies.Controller;


DataBaseController.CreateTablesSqlServer();

MainController mainController = new MainController();
mainController.MainOptions();

