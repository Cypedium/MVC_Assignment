using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    interface IPersonService
    {
        Person Create(string name, string country);
        bool Remove(int id);
        List<Person> All();
        List<Person> Filter(string filterInput);
        bool Update(PersonViewModel personViewModel, int id);
        Person Find(int id);
    }
}
