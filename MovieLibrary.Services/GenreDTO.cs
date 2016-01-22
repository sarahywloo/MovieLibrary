using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.Services {
    public class GenreDTO {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IList<MovieDTO> Movies { get; set; }
    }
}