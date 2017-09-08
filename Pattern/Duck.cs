using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    class Duck
    {
        public void fly()
        {
            Console.WriteLine("Duck is flying....");
        }
        public void quack()
        {
            Console.WriteLine("Quack Quack!!");
        }
        public void swim()
        {
            Console.WriteLine("Duck is swimming..");
        }
        public void display()
        {
            Console.WriteLine("Duck is white!");
        }
    }

    class RedDuck : Duck
    {
    }
}
