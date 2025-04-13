using System.ComponentModel.DataAnnotations;

namespace VetsMVC.Models
{
    public class Cat
    {
        public int CatID { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public string OwnerName { get; set; }

        public string OwnerNumber { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public string Conditions { get; set; }

    }
}

