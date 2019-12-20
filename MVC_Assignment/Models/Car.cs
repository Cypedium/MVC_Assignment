using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class Car
    {
        static int idCounter = 0; //Databas senare
        public static List<Car> carList = new List<Car>(); //Databas senare

        public int Id { get; set; }
        public string Brand { get; set; }
        public string ModelName { get; set; }

    }
}
