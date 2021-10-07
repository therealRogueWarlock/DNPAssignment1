using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Family
    {
        //public int Id { get; set; }
        [Required, MaxLength(10)]
        public string StreetName { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int HouseNumber { get; set; }
        public List<Adult> Adults { get; set; }
        public List<Child> Children { get; set; }
        public List<Pet> Pets { get; set; }

        public Family()
        {
            Adults = new List<Adult>();
        }

    }
}