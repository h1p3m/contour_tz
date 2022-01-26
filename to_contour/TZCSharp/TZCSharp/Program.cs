using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZCSharp
{
    class Program
    {



        public int[] FindInts(int[] array)
        {
            return array.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key).ToArray();
        }

  
        public void Print (int []array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + " ");
            }


            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //fill array random
            int min = 0;
            int max = 20;
            int[] array = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(min, max);

        
            }

            Program pr = new Program();
            //print array

            pr.Print(array);

            //find
            int[] array2 = pr.FindInts(array);


            Console.WriteLine("Все числа без копий");
            pr.Print(array2);



        }
    }




}
