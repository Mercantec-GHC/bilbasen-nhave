using System.Drawing;

namespace BilbasenBlazorApp.Models
{
    public abstract class Vehicle
    {
        public readonly string Brand;
        public readonly string Model;

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
