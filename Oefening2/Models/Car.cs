using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2.Models
{
    public class Car
    {
        public string TypeCar { get; set; }
        public string PlateNumber { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        //public static List<Car> AvailableCars { get; set; }

        public Car(string typeCar, string plateNumber, string brand, double price)
        {
            this.TypeCar = typeCar;
            this.PlateNumber = plateNumber;
            this.Brand = brand;
            this.Price = price;
        }

        public static void AddCar(List<Car> cars, Car car)
        {
            cars.Add(car);
        }
        public static void SellCar(List<Car> cars, Car car)
        {
            cars.Remove(car);
        }

        public static void ShowCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public override string ToString()
        {
            //==> Type: Truck with plate number: VFU-736 => Brand: Scania (95569€)
            return $"==> Type: {this.TypeCar} with the plate number: {this.PlateNumber} ==> Brand: {this.Brand} ({this.Price.ToString("C")})";
        }
    }
}
