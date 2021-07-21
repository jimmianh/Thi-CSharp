namespace thiCsharp
{
    public abstract class BaseClass
    {
        public double Weight  { get; set; }
        public string Name  { get; set; }

        public abstract void Show();

        public abstract void SetMe(double weight, string name);

    }
}