using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class Person
    {
        static int idCounter = 0; //Databas senare
        public static List<Person> personList = new List<Person>(); //Databas senare

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Person()
        {
            Id = ++idCounter;
        }
    }
}
