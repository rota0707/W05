using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wo5
{
    internal class Program

    {
     
      
        static void Main(string[] args)
        {
            int a;
           double c, f;

            // khởi tạo menu
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Covert *C --> *F.");
                Console.WriteLine("2. Covert *F --> *C.");
                Console.WriteLine("3. Exit.");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Nhập giá tri:");
                        double b = double.Parse(Console.ReadLine());
                        CF(b);
                        break;

                    case 2:
                        Console.WriteLine("Nhập giá tri:");
                        double bc = double.Parse(Console.ReadLine());
                        FC(bc);
                        break;

                }


            } while (a != 0);
        }
        public static double CF (double t){

            double ts = (9.0 / 5) * t + 32;
            Console.WriteLine("Nhiệt độ " + t + " *C sang *F  là:" + ts +" *F");
            return t;
        }
        public static double FC(double t)
        {

            double ts = (5.0 / 9) * (t - 32);
            Console.WriteLine("Nhiệt độ " + t + " *F sang *C  là:" + ts +" *C");
            return t;
        }
    }
}
