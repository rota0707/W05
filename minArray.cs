using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wo5
{
    internal class Program

    {
     
      
        static void Main(string[] args)    
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 9, 10 };
            Number(array);
            Console.ReadKey();
           
        }
       public static int Number(int[] number)
        {
            int min = number[0];
            int index = 0;
            for (int i = 0; i < number.Length; i++)
            {
               if( min > number[i])
                {
                    min = number[i];
                    index = i;
                }
            }
            Console.WriteLine("Phần tử trong mảng có giá trị nhỏ nhất là: " + min + " ở vị trí :" + index);

            return index;
        }
    }
}
