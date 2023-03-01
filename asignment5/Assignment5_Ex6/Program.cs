using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Ex6
{
    class clsstudent
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<clsstudent> lst = new List<clsstudent>();
            bool check = false;
            do
            {
                clsstudent obj = new clsstudent();
                Console.WriteLine("enter age");
                obj.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                obj.Name = Console.ReadLine();
                lst.Add(obj);
                Console.WriteLine("enter Y for continue exit for N");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                if (ch == 'Y')
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            } while (check);

            foreach (clsstudent tem in lst)
            {
                Console.WriteLine(tem.Name+" "+tem.Age);
            }
        }


    }
}
