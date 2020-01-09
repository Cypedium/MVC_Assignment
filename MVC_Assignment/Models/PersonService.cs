using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class PersonService : IPersonService
    {
        //Constructor 
        public int Id { get; set; }
        static int idCounter = 0; //Databas senare
        public PersonService()
        {
            Id = ++idCounter;
        }

        public string Name { get; set; }
        public string Country { get; set; }
        private static List<Person> personList = new List<Person>(); //Databas senare
        Person Create(string name, string country)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(country))
            {
                return null;
            }
            
             Person person = new Person()
                   {
                       Name = name,
                       Country = country
                   };

            return person;
        }
         
            bool Remove(int id);
            Person Find(int id);
            List<Person> All();
            bool Update(Person car);
    }
}
