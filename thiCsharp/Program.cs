using System;

namespace thiCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.WriteLine("Radius:");
            cylinder.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            cylinder.Height = double.Parse(Console.ReadLine());
            cylinder.Process();
            cylinder.Result();


            var lion = new Lion();
            var tiger = new Tiger();
            lion.SetMe(100, "lion");
            tiger.SetMe(200,"tiger");
            lion.Show();
            tiger.Show();
        }
    }
}