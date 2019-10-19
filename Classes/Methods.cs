using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Classes
{
    public class Methods
    {
        public int X;
        public int Y;

        public Methods(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Methods newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
    }
}
