using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class BusinessLogic
    {
        public bool AddNewMobileOperator(int index, int mobileOperatorId, string mobileOperatorName, int mobileOperatorRating)
        {
            DLL DataLinkObj = new DLL();
           
            if (DataLinkObj.AddMobileDataToTable(index, mobileOperatorId, mobileOperatorName, mobileOperatorRating))
            {
               
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public SqlDataReader DisplayMobileoperatorsData()
        {
            DLL DataLinkObj = new DLL();
            SqlDataReader Data = DataLinkObj.GetMobileOperatorsData();
            return Data;
        }

        public bool AddPersionDataToTable(int personsIndex, int personId, string personName, int mobileOperatorId)
        {
            DLL DataLinkObj = new DLL();

            if (DataLinkObj.AddPersonDataToTable(personsIndex, personId, personName, mobileOperatorId))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public SqlDataReader DisplayPersonData()
        {
            DLL DataLinkObj = new DLL();
            SqlDataReader Data = DataLinkObj.GetPersonsData();
            return Data;
        }

        public bool ValidateMobileoperatorName(string mobileOperatorName)
        {
            ConnectionToDataBase connection = new ConnectionToDataBase();
            DLL DataLinkObj = new DLL();
            SqlDataReader Data = DataLinkObj.GetMobileOperatorsData();
            
            while (Data.Read())
            {
                if (Data["MobileOperatorName"].Equals(mobileOperatorName))
                {
                    connection.CloseConnection();
                    return true;
                }
              //  Console.WriteLine($"{Data["MobileOperatorId"]}, {Data["MobileOperatorName"]}, {Data["MobileOperatorRating"]}");
            }
            connection.CloseConnection();
            return false;
        }

        public bool ValidateRating(int mobileOperatorRating)
        {
            if (mobileOperatorRating <= 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateMobileoperatorID(int mobileOperatorId)
        {
            ConnectionToDataBase connection = new ConnectionToDataBase();
            DLL DataLinkObj = new DLL();
            SqlDataReader Data = DataLinkObj.GetMobileOperatorsData();

            while (Data.Read())
            {
                if (Data["MobileOperatorId"].Equals(mobileOperatorId))
                {
                    connection.CloseConnection();
                    return true;
                }
                //  Console.WriteLine($"{Data["MobileOperatorId"]}, {Data["MobileOperatorName"]}, {Data["MobileOperatorRating"]}");
            }
            connection.CloseConnection();
            return false;
        }
    }
}

//public void CreateMobileOperators(int i)
//{
//    MobileOperator Entities = new MobileOperator();
//  //  Console.WriteLine("enter no of mobile operators are there : ");
//  //  int numberofoperators = int.Parse(Console.ReadLine());
//  //  for(int i=0;i< numberofoperators; i++)
//  //  {
//       // Console.WriteLine("enter mobile operator id : ");
//       // Entities.MobileOperatorId = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter name of operator");
//        Entities.MobileOperatorName = Console.ReadLine();
//        Console.WriteLine("enter rating of it : ");
//        Entities.MobileOperatorRating = int.Parse(Console.ReadLine());
//        DLL DatalogicLayer = new DLL();
//        if(DatalogicLayer.AddDataToTable(i,(i+1), Entities.MobileOperatorName, Entities.MobileOperatorRating))
//        {
//            Console.WriteLine("data added sucessfully ");
//        }
//        else
//        {
//            Console.WriteLine("somthning wrong");
//        }

//   // }

//}

//public void DisplayPersonsData()
//{
//    EntitiesClass Entities = new EntitiesClass();
//    DLL DatalogicLayer = new DLL();
//    SqlDataReader Data = DatalogicLayer.GetPersonsData();
//    while (Data.Read())
//    {

//        Console.WriteLine($"{Data["PersonId"]}, {Data["personName"]}, {Data["mobileOperatorId"]}");
//    }
//    Entities.CloseConnection();
//}


//public void CreateCustomersData(int i)
//{
//    EntitiesClass Entities = new EntitiesClass();
//    Console.WriteLine("enter name of customer");
//    Entities.PersonName = Console.ReadLine();
//    Console.WriteLine("enter rating of it : ");
//    Entities.MobileOperatorId = int.Parse(Console.ReadLine());
//    DLL DatalogicLayer = new DLL();
//    if (DatalogicLayer.AddPersionDataToTable(i, Entities.PersonName, Entities.MobileOperatorId))
//    {
//        Console.WriteLine("data added sucessfully ");
//    }
//    else
//    {
//        Console.WriteLine("somthning wrong");
//    }
//}

//public void DisplayMobileoperatorsData()
//{
//    EntitiesClass Entities = new EntitiesClass();
//    DLL DatalogicLayer = new DLL();
//    SqlDataReader Data = DatalogicLayer.GetMobileOperatorsData();
//    while (Data.Read())
//    {
//        Console.WriteLine($"{Data["MobileOperatorId"]}, {Data["MobileOperatorName"]}, {Data["MobileOperatorRating"]}");
//    }
//    Entities.CloseConnection();

//}

