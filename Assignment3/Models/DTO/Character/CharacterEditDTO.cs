using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models.DTO.Character
{
    public class CharacterEditDTO
    {
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public string Alias { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }
    }
}
