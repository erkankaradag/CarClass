using System;
namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Volkswagen",
                Model = "Caddy",
                Color = "Azul Mavisi",
                NumberOfDoors = 4
            };
            car1.CarDetails();

            Car car2 = new Car
            {
                Brand = "Volkswagen",
                Model = "Tiguan",
                Color = "Siyah",
                NumberOfDoors = 3
            };
            car2.CarDetails();

        }
    }
}