using System;

namespace conservation_of_momentum
{
    class main
    {
        static void Main(string[] args)
        {
            Object obj1 = new Object();
            Console.Write("Object1's initial velocity: ");
            obj1.Vi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Object1's mass: ");
            obj1.m = Convert.ToDouble(Console.ReadLine());

            Object obj2 = new Object();
            Console.Write("Object2's initial velocity: ");
            obj2.Vi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Object2's final velocity: ");
            obj2.Vf = Convert.ToDouble(Console.ReadLine());
            Console.Write("Object2's mass: ");
            obj2.m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Object1's final velocity is " + obj1.calculate_Vf(obj2.Vi, obj2.Vf, obj2.m));
        }
    }
}
