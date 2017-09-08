using System;
using Pattern.ICollection;
using Pattern.CActions;

namespace Pattern
{
    abstract class Duck
    {
        protected IFlyBehavior flybehavior;
        public Duck(){}
        public void Fly()
        {
            flybehavior.Fly();
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack!!");
        }
        public void Swim()
        {
            Console.WriteLine("Duck is swimming..");
        }
        public abstract void Display();
    }

    class RedDuck : Duck
    {
        public RedDuck()
        {
            flybehavior = new DuckSlowFly();
        }
    
        public override void Display()
        {
            Console.WriteLine("I'm RedDuck.....");
        }
    }

    class YelloDuck : Duck
    {
        public YelloDuck()
        {
            flybehavior = new DuckNonFly();
        }
        public override void Display()
        {
            Console.WriteLine("I'm YellowDuck.....");
        }
    }
}
