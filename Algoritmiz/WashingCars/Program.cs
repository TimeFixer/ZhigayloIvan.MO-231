using System;
using System.Collections.Generic;
namespace ConsoleApp43
{
    internal class Program
    {
        delegate void Washing();
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.AddCar(new Cars("BMW"));
            garage.AddCar(new Cars("Audi"));
            garage.AddCar(new Cars("Mercedes"));
            Washing Wcar;            
            Wcar = wash;            
            Wcar();
            void wash()
            {
                foreach (var car in Garage.cars)
                {
                    WashingCars.CleanCar(car);
                }
            }
        }
    }
    public class Cars
    {
        public string model;
        public Cars(string model)
        {
            this.model = model;
        }
    }
    class Garage
    {
        static public List<Cars> cars = new List<Cars>();
        public void AddCar(Cars car)
        {
            cars.Add(car);
        }
    }
    static class WashingCars
    {
        static public void CleanCar(Cars car)
        {
            Console.WriteLine($"Автомобиль {car.model} отмыт");
        }
    }
}