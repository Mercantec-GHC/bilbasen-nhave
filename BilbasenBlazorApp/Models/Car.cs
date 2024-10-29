namespace BilbasenBlazorApp.Models
{
    public class Car: Vehicle
    {
        public readonly string Color;
        public readonly int Year;
        public readonly int HorsePower;

        public Car(string brand, string model, string color, int year, int horsePower) : base(brand, model)
        {
            Color = color;
            Year = year;
            HorsePower = horsePower;
        }
    }
}
