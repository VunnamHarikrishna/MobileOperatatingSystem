using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Ex2
{


    public class CustomCol : CollectionBase
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
        static void Main(string [] args)
        {

            CustomCol lst = new CustomCol();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            IEnumerator ienu = lst.GetEnumerator();

            while (ienu.MoveNext())
            {
                Console.WriteLine(ienu.Current.ToString());
            }
            Console.ReadLine();
        }
    }




    //class customcollection
    //{
    //    ArrayList items;
    //    int indexnumber;
    //    public customcollection()
    //    {
    //        items = new ArrayList();
    //        indexnumber = -1;
    //    }
    //    public void AddItem(object itemToAdd)
    //    {
    //        items.Add(itemToAdd);
    //    }
    //    static void Main(string[] args)
    //    {
    //        customcollection mycustom = new customcollection();
    //        mycustom.AddItem(1);
    //        mycustom.AddItem(2);
    //        mycustom.AddItem(3);
    //        mycustom.AddItem(4);
    //        IEnumerator<customcollection> enumerator = mycustom.customcollection;
    //        while (mycustom.MoveNext())
    //        {
    //            Console.WriteLine(mycustom)
    //        }
    //    }
    //}


    //class IEnumtor
    //{
    //    static void Main(string[] args)
    //    {
    //        List<int> oyear = new List<int>();
    //        oyear.Add(1990);
    //        oyear.Add(1991);
    //        oyear.Add(1990);
    //        oyear.Add(1992);
    //        oyear.Add(2001);
    //        oyear.Add(1154);
    //        oyear.Add(2002);
    //        oyear.Add(2003);
    //        Console.WriteLine("=---------enumarale-----------");
    //        IEnumerable<int> ienum = (IEnumerable<int>)oyear;
    //        foreach (int i in ienum)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        //   ienum.GetEnumerator();
    //        Console.WriteLine("+================");
    //        IEnumerator<int> ienumrat = oyear.GetEnumerator();
    //        itarate1920(ienumrat);
    //        /*  while (ienumrat.MoveNext())
    //          {
    //              Console.WriteLine(ienumrat.Current.ToString());
    //          }
    //          Console.WriteLine("/////////////////////////////////");
    //          */

    //        Console.ReadLine();
    //    }

    //    private static void itarate1920(IEnumerator<int> year)
    //    {
    //        //itarate 1990 to 2001
    //        while (year.MoveNext())
    //        {
    //            Console.WriteLine(year.Current.ToString());
    //            if (Convert.ToInt16(year.Current) > 2000)
    //            {
    //                itarate20above(year);
    //            }
    //        }
    //    }
    //    private static void itarate20above(IEnumerator<int> year)
    //    {
    //        //above 2000
    //        while (year.MoveNext())
    //        {
    //            Console.WriteLine(year.Current.ToString());
    //        }


    //    }
    //}

}
