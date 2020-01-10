using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class Person
    {
        //static int idCounter = 0; //Databas senare
        //public static List<Person> personList = new List<Person>(); //Databas senare
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Förnamn")]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

       // public Person()
       // {
       //     Id = ++idCounter;
       // }
    }
}
