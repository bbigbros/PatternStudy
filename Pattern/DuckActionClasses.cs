using Pattern.ICollection;
using System;

namespace Pattern.CActions
{
    class DuckNonFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I dot't flying...");
        }
    }

    class DuckSlowFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("slow flying...");
        }
    }
}
