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

        [Display(Name = "Profile URL")]
        public string ProfileURL { get; set; }

        [Display(Name = "Full Name")]
        public string ActorName { get; set; }

        [Display(Name = "Biography")]
        public string ActorBio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
        public List<Actor_Movie> ActorMovie { get; set; }
    }
}
