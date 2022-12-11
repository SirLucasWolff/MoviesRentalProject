using MoviesRental.Domain.MovieModule;
using MoviesRental.Infra.SQL;
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
                        [Name],
                        [Category],
                        [Classification],
                        [ReleaseDate],
                        [Availability],
                        [AvailabilityMessage]
                    )
                    VALUES
                    (
                        @Name,
                        @Category,
                        @Classification,
                        @ReleaseDate,
                        @Availability,
                        @AvailabilityMessage
                    )";

        public string SqlSelect = @"SELECT * FROM MovieDB";

        public string SqlDelete = @"DELETE FROM MovieDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE MovieDB
                    SET
                        [Name] = @Name,
                        [Category] = @Category,
                        [Classification] = @Classification,
                        [ReleaseDate] = @ReleaseDate,
                        [Availability] = @Availability,
                        [AvailabilityMessage] = @AvailabilityMessage
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [NAME],
                        [CATEGORY],
                        [CLASSIFICATION],
                        [RELEASEDATE],
                        [AVAILABILITY],
                        [AVAILABILITYMESSAGE]
	                FROM
                        MovieDB
                    WHERE 
                        ID = @ID";
        
        public static string SqlSelectAll =
        @"SELECT
                        [ID],
                        [NAME],
                        [CATEGORY],
                        [CLASSIFICATION],
                        [RELEASEDATE],
                        [AVAILABILITY],
                        [AVAILABILITYMESSAGE]
          
                        FROM MovieDB";

        public string SelectSearch = @"SELECT * FROM MovieDB WHERE Name LIKE @Name";

        public string SelectByName = @"SELECT * FROM MovieDB WHERE Name = @Name";

        public bool InsertNew(Movie movie)
        {
            try
            {
                DataBaseController.DataBase(SqlInsert, GetParametersMovies(movie));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }

        static Dictionary<string, object> GetParametersMovies(Movie movie)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", movie.Id);
            parameters.Add("NAME", movie.Name);
            parameters.Add("CATEGORY", movie.Category);
            parameters.Add("CLASSIFICATION", movie.Classification);
            parameters.Add("RELEASEDATE", movie.ReleaseDate);
            parameters.Add("AVAILABILITY", movie.Availability);
            parameters.Add("AVAILABILITYMESSAGE", movie.AvailabilityMessage);

            return parameters;
        }

        public bool Delete(int id)
        {
            try
            {
                DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        public bool Edit(int id, Movie movie)
        {
            try
            {
                DataBaseController.DataBase(SqlEdit, GetParametersMovies(movie));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }

        public List<Movie> SelectAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, MovieConvert);
        }

        public Movie SelectById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, MovieConvert, AddParameters("ID", id));
        }

        public List<Movie> GetByReference(string name)
        {
            return DataBaseController.GetAll(SelectSearch, MovieConvert, AddParametersByName("NAME",name));
        }

        public List<Movie> GetListByName(string name)
        {
            return DataBaseController.GetAll(SelectByName, MovieConvert, AddParametersByName("NAME", name));
        }

        public Movie GetByName(string name)
        {
            return DataBaseController.GetId(SelectByName, MovieConvert, AddParametersByName("NAME", name));
        }

        private Dictionary<string, object> AddParametersByName(string v2, string name)
        {
            return new Dictionary<string, object>() { { v2, name} };
        }

        public Movie MovieConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string movieName = ((string)reader["NAME"]);
            string category = ((string)reader["CATEGORY"]);
            string classification = ((string)reader["CLASSIFICATION"]);
            DateTime releaseDate = ((DateTime)reader["RELEASEDATE"]);
            bool availability = ((bool)reader["AVAILABILITY"]);
            string availabilityMessage = ((string)reader["AVAILABILITYMESSAGE"]);

            Movie movie = new Movie(movieName,category,classification, releaseDate, availability, availabilityMessage);

            movie.Id = id;

            return movie;
        }

        public bool ExistMovieWithTheName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
