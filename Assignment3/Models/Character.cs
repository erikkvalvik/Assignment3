using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Character
    {
        public Character()
        {
            this.Movies = new HashSet<Movie>();
        }
        [Key]
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public string Alias { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
