using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Domain {
    public class Genre : IDbEntity, IActivatable {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IList <Movie> Movies { get; set; }

        public bool Active { get; set; } = true;
    }
}
