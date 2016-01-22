using MovieLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieLibrary.Controllers {
    public class GenresController : ApiController {

        private GenreService _genreService;

        public GenresController(GenreService genreService) {
            _genreService = genreService;
        }

        public IList<GenreDTO> Get() {
            return _genreService.List();
        }
    }
}
