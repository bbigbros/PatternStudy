using System;
using Pattern;


namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            RedDuck rd = new RedDuck();
            rd.Display();
            rd.Fly();
            Console.WriteLine();
            YelloDuck yd = new YelloDuck();
            yd.Display();
            yd.Fly();
            Console.WriteLine();
        }
    }
}
