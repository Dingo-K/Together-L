using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LAB3
{
    class Car
    {
        public static int count=0;
        public int ID { get; set; }
        private string CarsName;
        private string Model;
        private int Year;
        private string Color;
        private int Cost;
        private string Number;

        public int YearOfCar
        {
            get
            {
                return Year;
            }
        }
        

        public Car()
        {
            CarsName = "Honda";
            Model = "Accord";
            Year = 2009;
            Color = "Black";
            Cost = 9000;
            Number = "2205 AK-7";
            count++;
            Print();
            
        } 

        public Car( string CarsName, string Model, int Year, string Color, int Cost,ref string Number)
        {
            this.CarsName = CarsName;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
            this.Cost = Cost;
            this.Number = Number;
            count++;
            Print();
        }
         
        public void Print()
        {
            Console.WriteLine("CarsName: "+CarsName);
            Console.WriteLine("Model: "+Model);
            if (Year > 0 || Year < 2020)
            {
                Console.WriteLine("Year: " + Year);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine("Color: "+Color);
            if (Cost > 0)
            {
                Console.WriteLine("Cost: " + Cost);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine("Number: " + Number);
            Console.WriteLine("Count: " + count);
        }
                
            
    }

   
    class Program
    {
        static void PrintYear(int year)
        {
            Console.WriteLine("Years of car: "+(2020 - year));
        }
        static void Main(string[] args)
        {
            int year;
            Car honda = new Car();
            year = honda.YearOfCar;
            PrintYear(year);
            
        }
    }
}
