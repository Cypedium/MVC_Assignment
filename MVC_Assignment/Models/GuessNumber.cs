using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class GuessNumber
    {
        static Random random_ = new Random();
        public static int random = random_.Next(1, 100);
    }
}
