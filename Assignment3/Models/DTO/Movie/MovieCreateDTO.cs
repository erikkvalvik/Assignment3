using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models.DTO.Movie
{
    public class MovieCreateDTO
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Picture { get; set; }
        public string Trailer { get; set; }
        public int Franchise { get; set; }

    }
}
