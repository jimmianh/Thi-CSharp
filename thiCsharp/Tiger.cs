using System;

namespace thiCsharp
{
    public class Tiger:BaseClass
    {
        public override void Show()
        {
            Console.WriteLine($"Name :{Name}, Weight:{Weight} ");
        }

        public override void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}