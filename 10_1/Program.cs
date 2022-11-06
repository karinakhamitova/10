using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение угла:");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            int minute_ = Convert.ToInt32(Console.ReadLine());
            int sec_ = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus_, minute_, sec_);
            double total = angle.ToRadian();
            Console.WriteLine("{0}° {1}' {2}'' = {3:f3} радиан", gradus_, minute_, sec_, total);
            Console.ReadKey();
        }

    }




}
