using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    class Duck
    {
        public virtual void Fly()
        {
            Console.WriteLine("Duck is flying....");
        }
        public virtual void Quack()
        {
            Console.WriteLine("Quack Quack!!");
        }
        public virtual void Swim()
        {
            Console.WriteLine("Duck is swimming..");
        }
        public virtual void Display()
        {
            Console.WriteLine("Duck is white!");
        }
    }

    class RedDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("RedDuck is Red!!!");
        }
    }
}
