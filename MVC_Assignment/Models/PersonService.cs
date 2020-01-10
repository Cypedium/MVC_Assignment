using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class PersonService : IPersonService
    {
        static int idCounter = 0; 

        private static List<Person> personList = new List<Person>(); 

        public List<Person> All()
        {
            return personList;
        }
        public Person Create(string name, string country)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(country))
            {
                return null;
            }

            Person person = new Person()
            {
                       Id = ++idCounter,
                       Name = name,
                       Country = country
            };

            personList.Add(person);
            return person;
        }
         
        public bool Remove(int id)
        {
            foreach (Person item in personList)
            {
                if (item.Id == id)
                {
                    personList.Remove(item);
                    return true;
                }
            }
        return false;
        }
            //Person Find(int id);
            
            //bool Update(Person car);
    }
}
