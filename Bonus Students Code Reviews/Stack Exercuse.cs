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
            Stack _stack = new Stack();

            int ini = 0;
            int man = 5;

            for (int i = ini; i <= max; i++)
                _stack.Push(i);

            for (int i = ini; i <= max; i++)
                Console.WriteLine(_stack.Pop());

            Console.ReadLine();
        }
    }
}
