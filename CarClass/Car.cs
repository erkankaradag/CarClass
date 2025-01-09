using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Car
    {
        private string brand;
        private string model;
        private string color;
        private int numberOfDoors;


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if ( value == 2 || value == 4 )
                {
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz kapı sayısı! Kapı sayısı yalnızca 2 veya 4 olabilir.");
                    numberOfDoors = -1;
                }

            }
        }

        public void CarDetails()
        {
            Console.WriteLine($"Marka: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Renk: {Color}");
            Console.WriteLine($"KapıSayısı: {NumberOfDoors}");

        }


    }

}
