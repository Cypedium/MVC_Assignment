using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class PersonService : IPersonService
    {
        static int idCounter = 3;
        public string filterInput = "";
        private static List<Person> personList = new List<Person>();

        static PersonService()
        {
            personList.Add(new Person() { Id = 1, Name = "Elvira", Country = "Sverige" });
            personList.Add(new Person() { Id = 2, Name = "Klara", Country = "Sverige" });
            personList.Add(new Person() { Id = 3, Name = "Charles", Country = "England" });
        }

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
                       Id= ++idCounter,
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

        public Person Find(int id) 
            {
            return personList.SingleOrDefault(person => person.Id == id);
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

        public bool Update(PersonViewModel personViewModel, int id)
        { 
        if (personViewModel == null)
            {
                return false;
            }

            Person currentPerson = Find(id);

            if (id == 0)
            {
                return false;
            }

            currentPerson.Name = personViewModel.Name;
            currentPerson.Country = personViewModel.Country;
           
            //personList.Update(currentPerson);

            return true;
        }
    }
}

