using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Wo5
   
{
  
    internal class Program

    {

        
        static void Main(string[] args)    
        {
          int[] array = { 1, 2, 3, 4, 5, 6, 9, 10 };

            
            Console.WriteLine("Mảng giá trị ban đầu :");
            foreach(int vallue in array)
            {
                Console.Write(vallue + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Nhập phần tử  cần xóa");
            int vitri = int.Parse(Console.ReadLine());
            DeleteNumber(array, vitri);
           
            Console.ReadKey();
           
        }
       public static int DeleteNumber(int[] number,int a)
        {
            int[] mang = new int[number.Length - 1];
            int index = 0;
            bool isCheck = false;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == a)
                {
                    index = i;
                    isCheck = true;
                    break;
                }
                
            }
            if (isCheck == true)
            {
                // vị trí i trong mang banndau
                for (int y = 0; y < a; y++)
                {
                    mang[y] = number[y];
                }


                for (int j = index; j < number.Length - 1; j++)
                {
                    mang[j] = number[j + 1];
                }

                Console.WriteLine("Mảng giá trị mới là:");
                foreach (int giatri in mang)
                {
                    Console.Write(giatri + " ");
                }
            }
            else
            {
                Console.WriteLine("Phần tử trên kkhoong có trong mảng");
            }
           
           
            

            return a;
        }
    }
}
