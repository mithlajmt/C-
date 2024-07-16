using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey comeon");
            int x=2,y=3;
            int age = 10;
            long num = 4545458924983249294L;
            double fr = 10.3D;
            float floatin = 13.253400F;
            decimal money = 232323M;

            age = 89;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(age);
            Console.WriteLine(num);
            Console.WriteLine(fr);
            Console.WriteLine(floatin);
            Console.WriteLine(money);



            //STRING VARIABLES 

            char name = 'k';
          Console.WriteLine(name);
            string namer = "loki";
          Console.WriteLine(namer);


            //string into number

            string strng = "2323";
            int strngtonum = Convert.ToInt32(strng);
            Console.WriteLine(strngtonum);

            Console.ReadLine();

        }
    }
}
