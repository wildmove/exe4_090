﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise_4
{
    class Program
    {
        //Declare array
        char[] array = new char[18];
        int max = 18;
        int top = -1;

        bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
        }


        public void push()
        {

        }

        public void pop()
        {
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
                Console.WriteLine("\nThe popped element is: " + top);
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
                    Console.WriteLine("Array Stack: " + array[i]);
                }
            }
        }

        static void Main(String[] args)
        {

        }




    }
}



// Data types char
// max number = rata2(9 + 90 + 1 + 2 x 10 - 10)
//            = 100 + 20 - 10
//            = 110/6 = 18
//array = wildan