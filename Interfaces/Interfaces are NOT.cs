using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Interfaces
{
    public class TextBox : Interfaces_are_NOT, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }

    public class Interfaces_are_NOT
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}
