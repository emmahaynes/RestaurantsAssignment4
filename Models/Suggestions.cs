using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Emma Haynes 2-10-21

namespace RestaurantsAssignment4.Models
{
    public class Suggestions
    {
        //sets attributes for the suggestions class
        [Required]
        public string Name { get; set; }
        [Required]
        public string Restaurant { get; set; }
        [Required]
        public string FavDish { get; set; }
        //Sets phone number format to XXX-XXX-XXXX
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage ="Please format your phone number XXX-XXX-XXXX")]
        public string Phone { get; set; }
    }
}
