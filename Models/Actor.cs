using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfileURL { get; set; }
        public string ActorName { get; set; }
        public string ActorBio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
        public List<Actor_Movie> ActorMovie { get; set; }
    }
}
