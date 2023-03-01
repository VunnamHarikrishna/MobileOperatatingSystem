using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person();
            obj1.Name = "john";
            Person obj2 = new Person();
            obj2.Name = "bill";
            Person obj3 = new Person();
            obj3.Name = "dell";
            Person obj4 = new Person();
            obj4.Name = "mishra";
            ArrayList lst = new ArrayList();

            lst.Add(obj1);
            lst.Add(obj2);
            lst.Add(obj3);
            lst.Add(obj4);
            // Console.WriteLine(lst[0].GetType());
            lst.Add(new Person("aa"));

            Console.WriteLine(lst.Count);
            foreach (var tem in lst)
            {

                Person te = (Person)tem;
                Console.WriteLine(te.Name);


            }
            Console.ReadLine();
        }
    }
}
//lst.Add("aa");
//Console.WriteLine(lst.Count);
//foreach (var tem in lst)
//{
//    if (tem.GetHashCode() > 0)
//    {

//        Person te = (Person)tem;
//        Console.WriteLine(te.Name);
//    }
//    else
//    {
//        Console.WriteLine(tem);
//    }

//}