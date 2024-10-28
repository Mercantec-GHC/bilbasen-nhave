using BilbasenConsoleApp.DomainModels;

namespace BilbasenConsoleApp
{
    internal class Program
    {
        public static readonly List<Car> ALLCARS = new List<Car>();

        static void Main(string[] args)
        {
            CreateCars();

            var firstCarBrand = GetCarFromIndex(0).Brand;
            var carsByBrand = GetCarsByBrand(firstCarBrand).Count();
            Console.WriteLine($"{carsByBrand} Cars of brand '{firstCarBrand}':");
            PrintCarsByBrand(firstCarBrand);
            Console.WriteLine();

            Console.WriteLine("Red Cars:");
            PrintCarsByColor("red");
            Console.WriteLine();

            Console.WriteLine("Cars with more than 200hp:");
            PrintCarsByHorsepowerAbove(200);
            Console.WriteLine();

            Console.WriteLine("All cars from 1980 to 1999:");
            PrintCarsByYearRange(1999, 1980);
            Console.WriteLine();
        }

        private static void CreateCars()
        {
            AddCar(new Car("Ford", "Mustang", "Red", 1963, 430));
            AddCar(new Car("Toyota", "Camry", "Red", 2020, 200));
            AddCar(new Car("Chevrolet", "Corvette", "Red", 2022, 650));
            AddCar(new Car("Ford", "Bronco", "Red", 2021, 300));
            AddCar(new Car("Mustang", "2+2 Fastback", "Red", 1966, 200));
            AddCar(new Car("Ford", "Capri", "Black", 1969, 107));
            AddCar(new Car("Toyota", "Camry", "Red", 2010, 180));
            AddCar(new Car("Ford", "Mustang", "Blue", 2015, 300));
            AddCar(new Car("Honda", "Civic", "Green", 2012, 150));
            AddCar(new Car("BMW", "3 Series", "Black", 2018, 250));
            AddCar(new Car("Mercedes", "C-Class", "White", 2020, 280));
            AddCar(new Car("Audi", "A4", "Grey", 2019, 220));
            AddCar(new Car("Volkswagen", "Golf", "Yellow", 2011, 140));
            AddCar(new Car("Nissan", "Altima", "Purple", 2013, 170));
            AddCar(new Car("Mazda", "Mazda3", "Pink", 2014, 160));
            AddCar(new Car("Chevrolet", "Malibu", "Orange", 2016, 190));
            AddCar(new Car("Toyota", "Corolla", "Red", 2011, 140));
            AddCar(new Car("Ford", "Fiesta", "Blue", 2012, 120));
            AddCar(new Car("Honda", "Accord", "Green", 2013, 190));
            AddCar(new Car("BMW", "5 Series", "Black", 2014, 300));
            AddCar(new Car("Mercedes", "E-Class", "White", 2015, 250));
            AddCar(new Car("Audi", "A6", "Grey", 2016, 220));
            AddCar(new Car("Volkswagen", "Passat", "Yellow", 2017, 180));
            AddCar(new Car("Nissan", "Maxima", "Purple", 2018, 200));
            AddCar(new Car("Mazda", "Mazda6", "Pink", 2019, 170));
            AddCar(new Car("Chevrolet", "Impala", "Orange", 2020, 240));
            AddCar(new Car("Toyota", "Yaris", "Red", 2012, 110));
            AddCar(new Car("Ford", "Edge", "Blue", 2013, 210));
            AddCar(new Car("Honda", "Fit", "Green", 2014, 130));
            AddCar(new Car("BMW", "X3", "Black", 2015, 250));
            AddCar(new Car("Mercedes", "GLC", "White", 2016, 220));
            AddCar(new Car("Audi", "Q5", "Grey", 2017, 240));
            AddCar(new Car("Volkswagen", "Tiguan", "Yellow", 2018, 200));
            AddCar(new Car("Nissan", "Rogue", "Purple", 2019, 190));
            AddCar(new Car("Mazda", "CX-5", "Pink", 2020, 180));
            AddCar(new Car("Chevrolet", "Equinox", "Orange", 2021, 230));
            AddCar(new Car("Toyota", "RAV4", "Red", 2013, 190));
            AddCar(new Car("Ford", "Explorer", "Blue", 2014, 250));
            AddCar(new Car("Honda", "CR-V", "Green", 2015, 200));
            AddCar(new Car("BMW", "X5", "Black", 2016, 300));
            AddCar(new Car("Mercedes", "GLE", "White", 2017, 270));
            AddCar(new Car("Audi", "Q7", "Grey", 2018, 280));
            AddCar(new Car("Volkswagen", "Atlas", "Yellow", 2019, 260));
            AddCar(new Car("Nissan", "Murano", "Purple", 2020, 240));
            AddCar(new Car("Mazda", "CX-9", "Pink", 2021, 230));
            AddCar(new Car("Chevrolet", "Traverse", "Orange", 2022, 280));
            AddCar(new Car("Toyota", "Highlander", "Red", 2014, 240));
            AddCar(new Car("Ford", "Expedition", "Blue", 2015, 300));
            AddCar(new Car("Honda", "Pilot", "Green", 2016, 250));
            AddCar(new Car("BMW", "X6", "Black", 2017, 330));
            AddCar(new Car("Mercedes", "GLS", "White", 2018, 320));
            AddCar(new Car("Audi", "Q8", "Grey", 2019, 310));
            AddCar(new Car("Volkswagen", "Touareg", "Yellow", 2020, 290));
            AddCar(new Car("Nissan", "Armada", "Purple", 2021, 280));
            AddCar(new Car("Mazda", "MX-5", "Pink", 2022, 260));
            AddCar(new Car("Chevrolet", "Blazer", "Orange", 2023, 300));
            AddCar(new Car("Toyota", "Tacoma", "Red", 2015, 220));
            AddCar(new Car("Ford", "F-150", "Blue", 2016, 400));
            AddCar(new Car("Honda", "Ridgeline", "Green", 2017, 250));
            AddCar(new Car("BMW", "M3", "Black", 2018, 450));
            AddCar(new Car("Mercedes", "AMG GT", "White", 2019, 500));
            AddCar(new Car("Audi", "RS5", "Grey", 2020, 450));
            AddCar(new Car("Volkswagen", "GTI", "Yellow", 2021, 300));
            AddCar(new Car("Nissan", "370Z", "Purple", 2022, 350));
            AddCar(new Car("Mazda", "MX-5", "Pink", 2023, 200));
            AddCar(new Car("Chevrolet", "Camaro", "Orange", 2024, 400));
            AddCar(new Car("Toyota", "Supra", "Red", 2016, 350));
            AddCar(new Car("Ford", "GT", "Blue", 2017, 600));
            AddCar(new Car("Honda", "S2000", "Green", 2018, 300));
            AddCar(new Car("BMW", "Z4", "Black", 2019, 350));
            AddCar(new Car("Mercedes", "SL", "White", 2020, 450));
            AddCar(new Car("Audi", "TT", "Grey", 2021, 300));
            AddCar(new Car("Volkswagen", "Beetle", "Yellow", 2022, 200));
            AddCar(new Car("Nissan", "Leaf", "Purple", 2023, 150));
            AddCar(new Car("Mazda", "CX-3", "Pink", 2024, 170));
            AddCar(new Car("Chevrolet", "Bolt", "Orange", 2025, 200));
            AddCar(new Car("Toyota", "Prius", "Red", 2017, 110));
            AddCar(new Car("Ford", "Fusion", "Blue", 2018, 200));
            AddCar(new Car("Honda", "Insight", "Green", 2019, 150));
            AddCar(new Car("BMW", "i3", "Black", 2020, 170));
            AddCar(new Car("Mercedes", "EQC", "White", 2021, 300));
            AddCar(new Car("Audi", "e-tron", "Grey", 2022, 350));
            AddCar(new Car("Volkswagen", "ID.4", "Yellow", 2023, 250));
            AddCar(new Car("Nissan", "Ariya", "Purple", 2024, 300));
            AddCar(new Car("Mazda", "MX-30", "Pink", 2025, 150));
            AddCar(new Car("Chevrolet", "Volt", "Orange", 2026, 160));
            AddCar(new Car("Random", "Car", "Orange", 1987, 2));
        }

        static Car AddCar(Car car)
        {
            ALLCARS.Add(car);
            return car;
        }

        static Car GetCarFromIndex(int index)
        {
            index = Math.Max(0, Math.Min(ALLCARS.Count-1, index));

            return ALLCARS[index];
        }

        static List<Car> GetCarsByBrand(string brand)
        {
            List<Car> cars = new List<Car>();

            brand = brand.ToLower();
            foreach (Car car in ALLCARS)
            {
                if (car.Brand.ToLower() == brand)
                {
                    cars.Add(car);
                }
            }

            return cars;
        }

        static void PrintCarsByBrand(string brand)
        {
            foreach (Car car in GetCarsByBrand(brand))
            {
                Console.WriteLine(car.ToString());
            }
        }

        static void PrintCarsByColor(string color)
        {
            color = color.ToLower();
            foreach (Car car in ALLCARS)
            {
                if (car.Color.ToLower() == color)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        static void PrintCarsByHorsepowerAbove(int horsepower)
        {
            foreach (Car car in ALLCARS)
            {
                if (car.HorsePower > horsepower)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        static void PrintCarsByYearRange(int startYear, int endYear)
        {
            int max = Math.Max(startYear, endYear);
            int min = Math.Min(startYear, endYear);

            foreach (Car car in ALLCARS)
            {
                if (car.Year >= min && car.Year <= max)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }
    }
}
