using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Movie
    {
        public Movie()
        {
            this.Characters = new HashSet<Character>();
        }
        public virtual ICollection<Character> Characters { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Picture { get; set; }
        public string Trailer { get; set; }
        [ForeignKey("Franchises")]
        public int FranchiseId { get; set; }
        public Franchise Franchise { get; set; }
    }
}
