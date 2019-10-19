using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Classes
{
    public class Fields
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Fields(int id)
        {
            this.Id = id;
        }

        public Fields(int id , string name)
        {

        }
    }

    public class Order
    {

    }
}
