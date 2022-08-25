using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesRental.Domain.MovieModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.DataBuilderTest.MovieModule
{
    [TestClass]
    public class MovieDataBuilder
    {
        private Movie movie;

        public Movie Build()
        {
            return movie;
        }

        public MovieDataBuilder()
        {
            movie = new Movie();
        }

        public MovieDataBuilder WithName(string name)
        {
            movie.Name = name;
            return this;
        }

        public MovieDataBuilder WithCategory(string category)
        {
            movie.Category = category;
            return this;
        }

        public MovieDataBuilder WithClassification(string classification)
        {
            movie.Classification = classification;
            return this;
        }

        public MovieDataBuilder WithReleaseDate(DateTime date) 
        {
            movie.ReleaseDate = date;
            return this;
        }

        public Movie GenerateCompleteMovie()
        {
            return this.WithCategory("testName")
                .WithClassification("testName")
                .WithName("testName")
                .WithReleaseDate(DateTime.Now).Build();
        } 
    }
}
