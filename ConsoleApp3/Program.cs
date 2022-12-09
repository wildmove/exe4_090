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
                top = top - 1;
                Console.WriteLine("\nThe popped element is: " + wildan[top]);
                
        }

        public void display()
        {
            if(empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (int i = 0; i < top; i++)
                {
                    Console.WriteLine("<" + wildan[i] + ">");
                }
            }
        }

        static void Main(string[] args)
        {
            StackArray s = new StackArray(18);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop. ");
                Console.WriteLine("3. Display. ");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();

                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        s.push();
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
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