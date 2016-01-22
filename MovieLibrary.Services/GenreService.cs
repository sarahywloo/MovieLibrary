using MovieLibrary.Domain;
using MovieLibrary.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Services {
    public class GenreService {

        private GenreRepository _genreRepo;

        public GenreService(GenreRepository genreRepo) {
            _genreRepo = genreRepo;
        }

        //Convert a genre into a genreDTO by creating a Map method

        public GenreDTO Map(Genre dbItem) {
            var dto = new GenreDTO() {
                Id = dbItem.Id,
                Name = dbItem.Name,
                Movies = (from m in dbItem.Movies
                          select new MovieDTO() {
                              Id = m.Id,
                              Title = m.Title,
                              Duration = m.Duration,
                              Rating = m.Rating,
                              ReleaseDate = m.ReleaseDate,
                              Description = m.Description,
                              PosterUrl = m.PosterUrl
                          }).ToList()
            };
            return dto;
        }

        public IList<GenreDTO> List() {
            return (from g in _genreRepo.List()
                    select Map(g)).ToList();
        }
    }
}
