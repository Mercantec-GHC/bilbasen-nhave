using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilbasenConsoleApp.DomainModels
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int HorsePower { get; set; }

        public Car(string brand, string Model, string color, int Year, int HorsePower)
        {
            this.Brand = brand;
            this.Model = Model;
            this.Color = color;
            this.Year = Year;
            this.HorsePower = HorsePower;
        }

        public override string ToString()
        {
            return $"{this.Brand} : {this.Model} : {this.Color} : {this.Year} : {this.HorsePower}hp";
        }
    }
}
