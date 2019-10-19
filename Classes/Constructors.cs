using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intermediate.NewFolder1;

namespace Intermediate.Classes
{
    public class Constructors
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Constructors()
        {
            Orders = new List<Order>();
        }

        public Constructors(int id)
            : this()
        {
            this.Id = id;
        }

        public Constructors(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
