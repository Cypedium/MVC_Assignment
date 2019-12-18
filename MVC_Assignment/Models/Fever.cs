using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class Fever
    {
        static int idCounter = 0;
        public static List<Fever> feversList = new List<Fever>();
        public int Id { get; set; }
        public string Info { get; set; }

        public Fever()
        {
            Id = ++idCounter;
        }
    }
}
