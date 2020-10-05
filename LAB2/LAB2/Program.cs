using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //second();
            Check();

        }
        static void First_a()
        {
            int fp = 24;
            bool d = true;
            string word = "hi";
            Console.WriteLine($"демонстрация {fp} {d} {word}");
        }
        static void First_b()
        {
            int first = 248;
            long ff = first;
            short type1 = 2;
            int type = type1;
            object prim = first, prim1 = type1 ;
        //-----------------------------------
            double fs = 2.4;
            int a;
            a = (int)fs;
            long ac = 28;
            int c;
            c = (int)ac;


;        }
        static void First_c()
        {
            int a = 32;
            object b = a;
            int c;
            c = (int)b;
        }

        static void First_d()
        {
            var t = 32;
            Console.WriteLine(t.GetType());
        }
        static void First_e()
        {
            string ab = null;
            int? ac = null;
        }
        static void First_f()
        {
            var r = 32;

            
        }

        static void third_a()
        {
            int[,] arr = new int[4, 5];
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = ran.Next(1, 15);
                    Console.Write("\t"+ arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void third_b()
        {
            Console.WriteLine("Введите длинну массива");
            int length;
            length = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[length];
            for (int j = 0; j < length; j++)
            {
                arr[j] = Console.ReadLine();
                
            }

            for (int j = 0; j < length; j++)
            {
                Console.WriteLine(arr[j]);
            }

        }

        static void third_c()
        {
            
            int[][] array = new int[3][];
            array[0] = new int[2];
            array[1] = new int[3];
            array[2] = new int[4];
            for (int i=0;i <array.Length;i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("Введите цифры");
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void third_d()
        {
            var ard = new object[0];
            var str = "";
        }

        static void fourth_a()
        {
            (int, string, char, ulong) person = (25, "vl", 'a', 2);
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item3);
            Console.WriteLine(person.Item4);
            Console.WriteLine(person);

            int a;
            a = person.Item1;
        }

        static void second()
        {
            const string a = "5";
            const string b = "5";
            if(a==b)
            {
                Console.WriteLine(true);
            }
            string first = "abc";
            string second = "def";
            string third = "ghi";
            Console.WriteLine(first + second);
            string fourth = first;
            first = first.Remove(0, 1);
            Console.WriteLine(first);
            string ac = null;
            string ab = "abcdef";
            Console.WriteLine(String.IsNullOrEmpty(ac));
            Console.WriteLine(String.IsNullOrEmpty(ab));

            StringBuilder hello = new StringBuilder("sghsgnoesngoe", 40);
            hello.Remove(0,3);


        }

        static int getresult()
        {
            int a = 5;


            return a ;
        }
        
       static void Check()
        {
            int a = int.MaxValue;
            a = a + 1;
            Console.WriteLine(a);
            a = int.MaxValue;
            checked
            {
                a = a + 1;
                Console.WriteLine(a);
            }

        }
        

    }



}
