using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Inheritance_Second
{
    public class Access_Modifiers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
        }

        public int CalculateRating()
        {
            return 0;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}

