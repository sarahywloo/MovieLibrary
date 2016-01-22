using CoderCamps.Infrastructure.Repository;
using MovieLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Infrastructure.Persistance {
    public class GenreRepository : GenericRepository<Genre> {

        public GenreRepository(DataContext db) : base(db) { }


    }
}
