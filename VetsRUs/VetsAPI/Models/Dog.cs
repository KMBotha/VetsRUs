using System.ComponentModel.DataAnnotations;

namespace VetsAPI.Models
{
    public class Dog
    {
        [Key]
        public int DogID { get; set; }

        [Required]
        [StringLength(50)] 
        public string Name { get; set; }

        [Required]
        [StringLength(50)] 
        public string Breed { get; set; }

        [Required]
        [StringLength(50)] 
        public string OwnerName { get; set; }

        [Required]
        [StringLength(100)] 
        public string OwnerNumber { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        [StringLength(100)]
        public string Conditions { get; set; }

    }
}
