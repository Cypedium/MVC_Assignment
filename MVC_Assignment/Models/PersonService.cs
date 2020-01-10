using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class PersonService : IPersonService
    {
        static int idCounter = 0;
        public string filterInput = "";
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

        
        public List<Person> Filter(string filterInput)
        {
            List<Person> filterPersonList = new List<Person>();
            foreach (Person item in personList)
            {
                if (item.Name == filterInput || item.Country == filterInput)
                {
                    filterPersonList.Add(item);
                }
            }
            return filterPersonList;
        }
            
            //bool Update(Person person);
    }
}
