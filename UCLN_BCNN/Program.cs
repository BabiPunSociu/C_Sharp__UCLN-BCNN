using System;
using System.Collections;
namespace UCLN_BCNN
{
    class Program
    {
        /**
         * Tim UCLN
         */
        static int UCLN(int a, int b)
        {
            if(a==0 && b == 0)
            {
                Console.WriteLine("Không có");
                return -1;
            }
            else
            {
                if (a == 0 || b == 0)
                    return a + b;
                while(a!=b)
                {
                    if (a > b)
                        a -= b;
                    b -= a;
                }
                return a;
            }    
        }

        /**
         * Tim BCNN
         */
        static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);       // BCNN = (a*b)/UCLN;
        }

        /**
        * Ham main
        */
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong a = ");
            String strA = Console.ReadLine();
            int a = Convert.ToInt32(strA);
            Console.Write("Nhap so nguyen duong b = ");
            String strB = Console.ReadLine();
            int b = Convert.ToInt32(strB);
            // tinh USCLN cua a và b
            Console.Write("USCLN cua {0} va {1} la: {2} \n", a, b, UCLN(a, b));
            // tinh BSCNN cua a và b
            Console.Write("USCLN cua cua {0} va {1} la: {2}", a, b, BCNN(a, b));
        }
    }
}