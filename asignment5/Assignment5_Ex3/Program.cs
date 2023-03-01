using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Ex3
{
    class Program
    {
        static List<int> Mylst = new List<int>();
        static void FillValue()
        {
            Mylst.Add(1);
            Mylst.Add(2);
            Mylst.Add(3);
            Mylst.Add(4);
            Mylst.Add(5);
        }
        static void Main(string[] args)
        {
             Program obj = new Program();
            //  obj. Consumer();
            //for(int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine(GetVales());
            //}
            FillValue();
            foreach (int i in Filter())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static IEnumerable<int> Filter()
        {
            int tol = 0;
            //List<int> temp = new List<int>();
            foreach(int i in Mylst)
            {
               // if (i > 3) {
                    //temp.Add(i);
                    tol = tol + i;
                    yield return tol;
                  //  }
            }
           // return temp;
        }

        //private static string GetVales()
        //{
        //    return "100";
        //    return "1001";
        //    return "1002";
        //    return "1003";
        //    return "1004";
        //}

        public void Consumer()
        {
            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }
        }
        public IEnumerable<int> Integers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }
    }
}
