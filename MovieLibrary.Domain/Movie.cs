using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Domain {
    public class Movie : IDbEntity, IActivatable {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        //so that duration is optional
        public int? Duration { get; set; }

        public string Rating { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Description { get; set; }

        public string PosterUrl { get; set; }

        public IList<Actor> Actors { get; set; }

        public Genre Genres { get; set; }

        public bool Active { get; set; } = true;

    }
}
