using MoviesRental.DataBase;
using MoviesRental.Domain.MovieModule;
using RentalMovies.Screen;
using RentalMovies.Screen.MovieModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.MovieModule
{
    public class MovieController : MovieRepository
    {
        MovieScreen movieScreen = new MovieScreen();

        List<Movie> movieList = new List<Movie>();

        public string SqlInsert = @"INSERT INTO MOVIEDB
                    (
                        [MovieName]
                    )
                    VALUES
                    (
                        @MovieName
                    )";

        public string SqlSelect = @"SELECT * FROM MOVIEDB";

        public string SqlDelete = @"DELETE FROM MOVIEDB WHERE ID = @Id";
                     
        public string SqlEdit = @"UPDATE MOVIEDB
                    SET
                        [MOVIENAME] = @MovieName
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [MOVIENAME]
	                FROM
                        MOVIEDB
                    WHERE 
                        ID = @ID";

        public string SqlSelectAll =
        @"SELECT
                        [ID],
                        [MOVIENAME]
          
                        FROM MOVIEDB";

        public void AddMovie(Movie movie)
        {
            Console.Clear();

            Random rnd = new Random();
            movie.Id = rnd.Next();

            Console.WriteLine("Insert the movie name:");
            movie.Name = Convert.ToString(Console.ReadLine());

            DataBaseController.DataBase(SqlInsert, GetParametersMovie(movie));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Movie created with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void DeleteMovie(int id)
        {
            Console.Clear();

            ShowMovies();

            Console.WriteLine("Select the movie id to delete:");
            id = Convert.ToInt32(Console.ReadLine());

            DataBaseController.DataBase(SqlDelete, AddParameters("ID",id));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Movie deleted with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void EditMovie(int id,Movie movie)
        {
            Console.Clear();

            ShowMovies();

            Console.WriteLine("Select the movie id to edit the name:");
            movie.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the new name:");
            movie.Name = Convert.ToString(Console.ReadLine());

            DataBaseController.DataBase(SqlEdit, GetParametersMovie(movie));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Movie edited with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void ShowMovies()
        {
            movieScreen.ShowMovies(SqlSelect);
        }

        public Movie GetById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, MovieConvert, AddParameters("ID", id));
        }

        private Dictionary<string, object> GetParametersMovie(Movie movie)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", movie.Id);
            parameters.Add("MOVIENAME", movie.Name);
            
            return parameters;
        }

        private Movie MovieConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string movieName = ((string)reader["MOVIENAME"]);

            Movie movie = new Movie(id, movieName);

            movie.Id = id;

            return movie;
        }

        private Dictionary<string, object> AddParameters(string v, object id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        public List<Movie> GetAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, MovieConvert);
        }

        public bool Validation(string value)
        {
            movieList = GetAll();

            foreach (var item in movieList)
            {
                if (item.Name == value)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
