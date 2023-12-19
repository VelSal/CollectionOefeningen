using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static void SellCar(List<Car> cars, int index)
        {
            cars.RemoveAt(index);
        }

        public static void ShowInfos(List<Car> cars)
        {
            Dealer dealer = new Dealer();
            Console.WriteLine($"=== DEALERSHIP ===\nLocation: {dealer.Address}\n");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine($"\nThere is {cars.Count} vehicle available.");
            Console.WriteLine($"{TrucksNumber(cars)} are trucks and {CarsNumber(cars)} are cars");
            Console.WriteLine($"The car dealer has {dealer.MoneyInAccount.ToString("C")} in the cash registery.");
            Console.WriteLine($"The total price of all cars is {CarsPrice(cars).ToString("C")}");
            Console.WriteLine($"The total price of all trucks is {TrucksPrice(cars).ToString("C")}");
        }

        private static double CarsPrice(List<Car> cars)
        {
            double sum = 0;
            foreach (var car in cars)
            {
                if (car.TypeCar == TypeOfCar.Car.ToString())
                {
                    sum += car.Price;
                }
            }
            return sum;
        }
        private static double TrucksPrice(List<Car> cars)
        {
            double sum = 0;
            foreach (var car in cars)
            {
                if (car.TypeCar == TypeOfCar.Truck.ToString())
                {
                    sum += car.Price;
                }
            }
            return sum;
        }
        private static double TrucksNumber(List<Car> cars)
        {
            double sum = 0;
            foreach (var car in cars)
            {
                if (car.TypeCar == TypeOfCar.Truck.ToString())
                {
                    sum ++;
                }
            }
            return sum;
        }
        private static double CarsNumber(List<Car> cars)
        {
            double sum = 0;
            foreach (var car in cars)
            {
                if (car.TypeCar == TypeOfCar.Car.ToString())
                {
                    sum++;
                }
            }
            return sum;
        }

        public override string ToString()
        {
            //==> Type: Truck with plate number: VFU-736 => Brand: Scania (95569€)
            return $"==> Type: {this.TypeCar} with the plate number: {this.PlateNumber} ==> Brand: {this.Brand} ({this.Price.ToString("C")})";
        }
    }
}
