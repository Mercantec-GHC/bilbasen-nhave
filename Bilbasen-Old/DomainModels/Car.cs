namespace DomainModels
{
    public class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }
        public int HoursePower { get; set; }
        public int NumberOfCylinders { get; set; }

        public Car(string? brand, string? model, int year, string? color, int hoursePower)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            HoursePower = hoursePower;
        }
    }
}
