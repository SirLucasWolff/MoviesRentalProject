using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesRental.DataBuilderTest.RentModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.Infra.ORM;
using MoviesRental.Infra.ORM.RentModule;
using MoviesRental.Infra.SQL;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MoviesRental.ORMTest.RentModule
{
    [TestClass]
    public class RentORM
    {
        RentOrmDAO rentOrmDAO;

        [TestCleanup()]
        public void ClearTables()
        {
            DataBaseController.DataBase("DELETE FROM RentDB WHERE Id IN (SELECT TOP 1 Id FROM RentDB ORDER BY Id DESC);");
        }

        public RentORM()
        {
            MoviesRentalDbContext moviesRentalDbContext = new MoviesRentalDbContext();
            rentOrmDAO = new RentOrmDAO(moviesRentalDbContext);
        }

        [TestMethod]
        public void Should_Insert_a_rent()
        {
            //Arrange

            RentDataBuilder rentDataBuilder = new RentDataBuilder();

            Rent rent = rentDataBuilder.GenerateCompleteRent();

            //Action

            rentOrmDAO.InsertNew(rent);

            //Assert

            Assert.AreEqual(rent, rentOrmDAO.SelectById(rent.Id));
        }
    }
}