using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
        public static bool IsOdd(int n)
        {
            return true;
        }
        public static bool IsOdd1(int n)
        {
            return false;

        }
        public static int Ceil(float x)
        {
            int kq = (int)x;
            if (x >= kq) return kq += 1;
            else return kq;
        }

              
           // intput: float x
           // output: a int the largest but not greater than x
           // idea: first chang float
            public static int Floor(float x)
            {
                int kq = (int)x;
                if (x >= kq) return kq;
                else return kq - 1;

            }
        }
    }

