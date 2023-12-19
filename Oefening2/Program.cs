using Oefening2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Car> cars = new List<Car>();

            Car.AddCar(cars, new Car(TypeOfCar.Truck.ToString(), "ABC-123", "Scania", 45236.00));
            Car.AddCar(cars, new Car(TypeOfCar.Car.ToString(), "DEF-456", "BMW", 58632.00));
            Car.AddCar(cars, new Car(TypeOfCar.Truck.ToString(), "XYZ-789", "Daf", 48632.00));
            Car.AddCar(cars, new Car(TypeOfCar.Car.ToString(), "QLF-007", "Volkswagen", 15478.00));

            Car.ShowCars(cars);

            Console.ReadLine();
            
        }
    }
}
