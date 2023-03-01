using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Ex1
{
    class ClsStudent
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        public static object ClsStudent { get; private set; }

        static ClsStudent GetStudent(int ID, ArrayList Lst)
        {
            ClsStudent obj = new ClsStudent();
            foreach(var temp in Lst)
            {
                obj = (ClsStudent)temp;
                if (obj.StudentId == ID)
                {
                    return obj;

                }
            }
            return null;
        }
        static ClsStudent AddStudent()
        {
            ClsStudent obj = new ClsStudent();
            Console.WriteLine("enter id ");
            obj.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("enter firstname ");
            obj.FirstName = Console.ReadLine();
            Console.WriteLine("enter lastname ");
            obj.LastName = Console.ReadLine();

            return obj;
        }
        static ArrayList  RemoveStudent(int id, ArrayList lst)
        {
            int i = 0;
            foreach(var tem in lst)
            {
                ClsStudent v1 = (ClsStudent)tem;
                if (v1.StudentId ==id)
                {
                    break;
                }
                i++;
            }
            lst.RemoveAt(i);
            return lst;
        }
        static void Main(string[] args)
        {
            ArrayList CustomcloectionList = new ArrayList();
            bool check = true;
            do
            {
                Console.WriteLine("enter choice 0. exit 1.add persion 2.remove 3.get 4.display");
                int val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 0:
                        Console.WriteLine("exiting .... \n  done.");
                        check = false;
                        break;
                    case 1:
                        ClsStudent temp = AddStudent();
                        CustomcloectionList.Add(temp);
                        break;
                    case 2:
                        Console.WriteLine("enter id ");
                        int StudentId = int.Parse(Console.ReadLine());
                        CustomcloectionList = RemoveStudent(StudentId, CustomcloectionList);
                        break;
                    case 3:
                        Console.WriteLine("enter id ");
                        StudentId = int.Parse(Console.ReadLine());
                        ClsStudent tempstudentdata = GetStudent(StudentId, CustomcloectionList);
                        Console.WriteLine(tempstudentdata.StudentId+"  "+ tempstudentdata.FirstName+" "+ tempstudentdata.LastName);
                        break;
                    case 4:
                        Display(CustomcloectionList);
                        break;
                    default:
                        Console.WriteLine("enter vaid option:");
                        break;
                }
            } while (check);
            Console.ReadLine();

        }

        private static void Display(ArrayList customcloectionList)
        {
           foreach(var temp in customcloectionList)
            {
                ClsStudent v1 = (ClsStudent)temp;
                Console.WriteLine(v1.StudentId + "  " + v1.FirstName + " " + v1.LastName);

            }
        }
    }
}
