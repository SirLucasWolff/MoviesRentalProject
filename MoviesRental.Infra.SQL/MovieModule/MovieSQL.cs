using MoviesRental.DataBase;
using MoviesRental.Domain.MovieModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.SQL.MovieModule
{
    public class MovieSQL : MovieRepository
    {
        public string SqlInsert = @"INSERT INTO MovieDB
                    (
                        [MovieName],
                        [Category],
                        [Classification],
                        [ReleaseDate]
                    )
                    VALUES
                    (
                        @MovieName,
                        @Category,
                        @Classification,
                        @ReleaseDate
                    )";

        public string SqlSelect = @"SELECT * FROM MovieDB";

        public string SqlDelete = @"DELETE FROM MovieDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE MovieDB
                    SET
                        [MovieName] = @MovieName,
                        [Category] = @Category,
                        [Classification] = @Classification,
                        [ReleaseDate] = @ReleaseDate 
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [MOVIENAME],
                        [CATEGORY],
                        [CLASSIFICATION],
                        [RELEASEDATE]
	                FROM
                        MovieDB
                    WHERE 
                        ID = @ID";
        
        public string SqlSelectAll =
        @"SELECT
                        [ID],
                        [MOVIENAME],
                        [CATEGORY],
                        [CLASSIFICATION],
                        [RELEASEDATE]
          
                        FROM MovieDB";

        public string SelectSearch = @"SELECT * FROM MovieDB WHERE MovieName LIKE @MovieName";

        public string SelectByName = @"SELECT * FROM MovieDB WHERE MovieName = @MovieName";

        public void AddMovie(Movie movie)
        {
            DataBaseController.DataBase(SqlInsert, GetParametersMovies(movie));
        }

        private Dictionary<string, object> GetParametersMovies(Movie movie)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", movie.Id);
            parameters.Add("MOVIENAME", movie.Name);
            parameters.Add("CATEGORY", movie.Category);
            parameters.Add("CLASSIFICATION", movie.Classification);
            parameters.Add("RELEASEDATE", movie.ReleaseDate);

            return parameters;
        }

        public void DeleteMovie(int id)
        {
            DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        public void EditMovie(int id, Movie movie)
        {
            DataBaseController.DataBase(SqlEdit, GetParametersMovies(movie));
        }

        public List<Movie> GetAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, MovieConvert);
        }

        public Movie GetById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, MovieConvert, AddParameters("ID", id));
        }

        public List<Movie> GetByReference(string name)
        {
            return DataBaseController.GetAll(SelectSearch, MovieConvert, AddParametersByName("MOVIENAME",name));
        }

        public List<Movie> GetByName(string name)
        {
            return DataBaseController.GetAll(SelectByName, MovieConvert, AddParametersByName("MOVIENAME", name));
        }

        private Dictionary<string, object> AddParametersByName(string v2, string name)
        {
            return new Dictionary<string, object>() { { v2, name} };
        }

        private Movie MovieConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string movieName = ((string)reader["MOVIENAME"]);
            string category = ((string)reader["CATEGORY"]);
            string classification = ((string)reader["CLASSIFICATION"]);
            DateTime releaseDate = ((DateTime)reader["RELEASEDATE"]);

            Movie movie = new Movie(id, movieName,category,classification, releaseDate);

            movie.Id = id;

            return movie;
        }
    }
}
