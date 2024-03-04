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
            Console.WriteLine("Bạn hãy nhập 1 chuỗi kí tự");
            string chuoi = Console.ReadLine();
            Console.WriteLine("Nhập tên kí tự bạn cần tìm kiếm:");
            char a = char.Parse(Console.ReadLine());
            TimKiem(a, chuoi);
           
            Console.ReadKey();
           
        }
        public static int TimKiem(char kitu,string chuoi)
        {
            int index = 0;
            bool isCheck = false;
            for(int i=0; i<chuoi.Length; i++)
            {
                if (chuoi[i]== kitu)
                {
                    index++;
                    isCheck = true;
                }
          
            }
            if (isCheck == true)
            {
                Console.WriteLine("Kí tự " + kitu + " xuất hiện " + index + " trong chuỗi");
            }
            else
            {
                Console.WriteLine("Kí tự bạn cần tìm kiếm không có trongc chuỗi");
            }
            return index;
        }
      
    }
}
