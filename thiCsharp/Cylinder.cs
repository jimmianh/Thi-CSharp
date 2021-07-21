using System;

namespace thiCsharp
{
    public class Cylinder
    {
        public double Radius{ get; set; }
        public double Height{ get; set; }

        private double BaseArea;
        private double LateralArea;
        private double TotalArea;
        private double Volume;

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Process();
            Console.WriteLine("Cylinder Characteristic");
            Console.WriteLine("Radius:" + Radius +"," +"Height:" +Height);
            Console.WriteLine("Base:" + BaseArea + " | " + "LateralArea:" + LateralArea + "|" + "TotalArea:" + TotalArea + " | " +"Volume:" + Volume);
        }
    }
}