using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Classes
{
    public class Constructors
    {
        public int Id;
        public string Name;

        public Constructors()
        {

        }

        public Constructors(int id)
        {
            this.Id = id;
        }

        public Constructors(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
