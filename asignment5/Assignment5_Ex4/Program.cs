using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Ex4
{
    public class CustomC : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }
        public void Remove(object item)
        {
            InnerList.Remove(item);
        }
        public new void Clear()
        {
            InnerList.Clear();
        }
        public new int Count()
        {
            return InnerList.Count;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         //   List<int> lst = new List<int>();
            CustomC lst = new CustomC();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            IEnumerable<int> ienu = Enu(lst);
            foreach (int i in ienu)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private static IEnumerable<int> Enu(CustomC ienu)
        {
            IEnumerator temp = ienu.GetEnumerator();
           while (temp.MoveNext())
            {
              yield  return (int)temp.Current;
            }         
        }

       }
}
//IEnumerator lst2= Enums(ienu);
//while(lst2.MoveNext())
//{
//    Console.WriteLine(lst2.Current);
//}
/*
 public static IEnumerator Enums(IEnumerable<int> lst)
        {
            // List implements IEnumerable, but could be any collection.
            List<string> list = new List<string>();

            foreach (object value in lst)
            {
                yield return value.ToString();
            }
           // return list.GetEnumerator();
        }

        private static void write(IEnumerable<CustomC> ienu)
        {
            foreach (CustomC t in ienu)
            {
              //  int temp = (int)t;
               // Console.WriteLine(temp);
            }
            throw new NotImplementedException();
        } 
*/