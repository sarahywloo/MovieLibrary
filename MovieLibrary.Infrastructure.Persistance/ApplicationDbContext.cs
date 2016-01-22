using MovieLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Infrastructure.Persistance {
    public class ApplicationDbContext : DataContext {

        //IDbSet is the interface to the tables
        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<Actor> Actors { get; set; }
        public IDbSet<Movie> Movies { get; set; }

    }
}
