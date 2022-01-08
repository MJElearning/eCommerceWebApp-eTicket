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
        [Required(ErrorMessage = "Profile URL is required..!")]
        public string ProfileURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Actor Name is required..!")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Actor Name should be between 2 and 60 characters")]
        public string ActorName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Actor Biography is required..!")]
        public string ActorBio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
        public List<Actor_Movie> ActorMovie { get; set; }
    }
}
