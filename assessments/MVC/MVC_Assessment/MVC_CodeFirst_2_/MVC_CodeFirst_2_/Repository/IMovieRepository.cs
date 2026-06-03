using MVC_CodeFirst_2_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst_2_.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();

        Movie GetById(int id);

        void Insert(Movie movie);

        void Update(Movie movie);

        void Delete(int id);

        void Save();
    }
}
