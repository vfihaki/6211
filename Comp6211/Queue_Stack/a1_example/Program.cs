using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        int top;
        int[] stack = new int[100];


        public void pop()
        {
            Console.WriteLine("{0}", stack[top--]);

        }

        public void push(char x)
        {

            if (top == 100 - 1)
            {
                Console.WriteLine("Stack is overflow");
            }

            else
            {
                stack[++top] = x;
            }

        }

        public void Main()
        {
            string word = "Sri Lanka";
            int len = word.Length;
            char[] array = word.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                push(array[i]);
            }

            for (int i = 0; i < len; i++)
            {
                pop();
            }
        }


    }
}