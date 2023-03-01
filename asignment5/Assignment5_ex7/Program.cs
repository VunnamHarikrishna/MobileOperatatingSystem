using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ex7
{
    class clstu
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // clstu obj = new clstu();
            IDictionary<int, clstu> lst = new Dictionary<int,clstu>();
            bool check = false;
            int index = 0;
            do
            {
                clstu obj = new clstu();
                index++;
                Console.WriteLine("enter name");
                obj.Name = Console.ReadLine();
                lst.Add(index,obj);
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

            foreach(KeyValuePair<int, clstu> kvp in lst)
            {
                clstu temp = kvp.Value;
                Console.WriteLine(temp.Name);
            }
            Console.ReadLine();

        }
    }
}
