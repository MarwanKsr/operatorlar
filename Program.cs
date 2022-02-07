
using System;
    namespace operatorlar
{
      class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c= a+1;
            b *= b;
            a += a;
            int d = a+b;
            Console.WriteLine(d);
            d = a*b ;
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine("-----------------------");

            if (a<b && d>c)
            {
                Console.WriteLine("A B'dan Buyuktur ve D C'dan buyuktur");
            }
            

        }
    } 

}