using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    [Keyless]
    public class CharacterMovie
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
