using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfileURL { get; set; }
        public string ProducerName { get; set; }
        public string ProducerBio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
