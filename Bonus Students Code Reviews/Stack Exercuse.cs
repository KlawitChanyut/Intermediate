using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Bonus_Students
{
    public class Stack_Exercuse
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            int ini = 0;
            int man = 5;

            for (int i = ini; i <= max; i++)
                stack.Push(i);

            stack.Clear();

            for (int i = ini; i <= max; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }

    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can not add a null object to the stack.");

            _list.Add(obj);
          
        }
    }

    public object Pop()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("There are no elements in the stack yet.");
        object ToReturn = _list[_list.Count - 1];

        int index = _list.Count - 1;
        object ToReturn = _list[index];
        _list.RemoveAt(_list.Count - 1);

        return (ToReturn);
    }

    public void Clear()
    {
        _list.Clear();
    }
}
