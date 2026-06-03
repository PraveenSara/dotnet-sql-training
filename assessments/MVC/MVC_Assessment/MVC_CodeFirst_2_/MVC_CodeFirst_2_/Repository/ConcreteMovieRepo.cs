using MVC_CodeFirst_2_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CodeFirst_2_.Repository
{
    public class ConcreteMovieRepo : IMovieRepository
    {
        MovieContext db = new MovieContext();

        public List<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return db.Movies.Find(id);
        }

        public void Insert(Movie movie)
        {
            db.Movies.Add(movie);
        }

        public void Update(Movie movie)
        {
            db.Entry(movie).State =
                System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            Movie movie = db.Movies.Find(id);

            if (movie != null)
                db.Movies.Remove(movie);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}