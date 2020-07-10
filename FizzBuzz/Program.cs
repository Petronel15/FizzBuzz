using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            int[] a=new int[100];
            int[] b = new int[100];
            int j = 0;
            int k = 0;
            for (int i = 1; i <= 100; i++)
            {
                int x = 0;
                int nr = i;
                while (nr>0)
                    {
                    if (nr/10==3)
                    {
                        x = x + 1;
                    }
                    nr = nr / 10;
                    }
                if (i % 3 == 0 || x>0)
                {
                    a[j] = i;
                    j++;
                }

                int l = 0;
                nr = i;
                while (nr > 0)
                {
                    if (nr / 10 == 5)
                    {
                        l = l + 1;
                    }
                    nr = nr / 10;
                }
                if (i % 5 == 0 || l > 0)
                {
                    b[k] = i;
                    k++;
                }

            }
            Console.WriteLine("Fizz numbers:");
            for (int i=0;i<j;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Buzz numbers:");
            for (int i = 0; i < k; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
