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
        
        public int ID;
        public string CarsName;
        public string Model;
        public int Year;
        public string Color;
        public int Cost;
        public string Number;

        public int YearOfCar
        {
            get
            {
                return Year;
            }
        }
        

        public Car()
        {
            ID = 164228;
            CarsName = "Honda";
            Model = "Accord";
            Year = 2009;
            Color = "Black";
            Cost = 9000;
            Number = "2205 AK-7";
            
            
            
        } 

        public Car( string CarsName, string Model, int Year, string Color, int Cost,ref string Number)
        {
            
            this.CarsName = CarsName;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
            this.Cost = Cost;
            this.Number = Number;
            
            
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
          
        //------------------------------------------------------- 
        int year,count=0;
            string nb = "2010";
            Car honda = new Car("bmw","M5",2015,"Black",80000,ref nb);
            honda.Print();
            count++;
            Console.WriteLine("count: " + count);
            year = honda.YearOfCar;
            PrintYear(year);
            Car first = new Car();
            Car second = new Car();
            Car third = new Car();
            Car[] arr = new Car[] {first,second,third };
            Console.Write("ID ");
            Console.WriteLine(honda.GetHashCode());
            for (int i = 0; i < 3; i++)
            {
                Console.Write("CarsName: " );
                arr[i].CarsName = Console.ReadLine();
                Console.Write("Model: ");
                arr[i].Model = Console.ReadLine();
                Console.Write("Year: ");
                arr[i].Year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Color: ");
                arr[i].Color = Console.ReadLine();
                Console.Write("Cost: ");
                arr[i].Cost = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number: ");
                arr[i].Number = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------");
                arr[i].Print();
                Console.Write("ID ");
                Console.WriteLine(arr[i].GetHashCode());
                count++;
                Console.WriteLine("count: " + count);
                Console.WriteLine("-----------------------------------------------------");




            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(arr[i].CarsName);

                if(2020-arr[i].Year>5)
                {
                    Console.WriteLine(arr[i].Model);
                }

                Console.WriteLine("---------------------------");




            }


        }
    }
}
