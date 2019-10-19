using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Classes
{
    class Properties
    {
        public string Name { get; set; }
        public Properties(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get 
            { 
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
