using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise_4
{
    class StackArray
    {
        public char[] wildan;
        public int top;
        public int max;

        public StackArray(int size)
        {
            wildan = new char[18];
            int top = -1;
            int max = 18;

        }
        

        bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
        }


        public void push()
        {
            if (top == max - 1)
                Console.WriteLine("\nStack Full");
            else
                Console.WriteLine("\nEnter an character: ");
                wildan[top] = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Push element :" + wildan[top]);
                top++;
        }

        public void pop()
        {
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
                Console.WriteLine("\nThe popped element is: " + wildan[top]);
                top = top - 1;
        }

        public void display()
        {
            if(empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (int i = 0; i < 17; i++)
                {
                    Console.WriteLine("Array Stack: " + wildan[top]);
                }
            }
        }

        




    }
}



// Data types char
// max number = rata2(9 + 90 + 1 + 2 x 10 - 10)
//            = 100 + 20 - 10
//            = 110/6 = 18
//array = wildan