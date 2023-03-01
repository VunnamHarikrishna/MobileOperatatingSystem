using BusinessLayer;
using Entities;
using System;
using System.Data.SqlClient;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {

           // EntitiesClass Entities = new EntitiesClass();
            BusinessLogic BLogics = new BusinessLogic();
            MobileOperator Mobileoperatorobj = new MobileOperator();
            ConnectionToDataBase connection = new ConnectionToDataBase();
            // create the mobile operator Data
            bool check = true;
            int mobileoperatorIndexer = 0,personsIndex=1;
            do
            {
                Console.WriteLine("enter your choice: \n\n 1.enter mobile operators data\n2.Display Mobile operators data\n3.enter new customer data\n4.Display persons Data\n" +
                                   "5.Display to to mobile operator by rating\n 6.surch persion by id \n7.Exit from this.");
                try
                {

                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("enter ID of operator:");
                            Mobileoperatorobj.MobileOperatorId = int.Parse(Console.ReadLine());
                            bool valid;
                            do
                            {
                                Console.WriteLine("enter name of operator");
                                Mobileoperatorobj.MobileOperatorName = Console.ReadLine();
                                valid = BLogics.ValidateMobileoperatorName(Mobileoperatorobj.MobileOperatorName);
                                if (!valid)
                                {
                                    Console.WriteLine("it is valid data");
                                }
                                else
                                {
                                    throw new Exception("in valid operator name");
                                }

                            } while (valid);
                            do
                            {
                                Console.WriteLine("enter rating of it : ");
                                Mobileoperatorobj.MobileOperatorRating = int.Parse(Console.ReadLine());
                                valid = BLogics.ValidateRating(Mobileoperatorobj.MobileOperatorRating);
                                if (valid)
                                {
                                    Console.WriteLine("it is valid data");
                                }
                                else
                                {
                                    Console.WriteLine("rating must be below 5");
                                }

                            } while (valid);
                            //
                            if (BLogics.AddNewMobileOperator(mobileoperatorIndexer , Mobileoperatorobj.MobileOperatorId, Mobileoperatorobj.MobileOperatorName, Mobileoperatorobj.MobileOperatorRating))
                            {
                                Console.WriteLine("data added sucessfully. ");
                            }
                            else
                            {
                                Console.WriteLine("somting went wrong");
                            }
                            // Logics.CreateMobileOperators(mobileoperatorIndexer);
                            mobileoperatorIndexer++;
                            break;
                        case 2:
                            SqlDataReader Data;
                            if (mobileoperatorIndexer <= 0)
                            {
                                throw new Exception("there is no data avilable");
                            }
                            else
                            {
                                Data = BLogics.DisplayMobileoperatorsData();
                                while (Data.Read())
                                {
                                    Console.WriteLine($"{Data["MobileOperatorId"]}, {Data["MobileOperatorName"]}, {Data["MobileOperatorRating"]}");
                                }
                                connection.CloseConnection();
                            }
                            break;
                        case 3:

                            PersonDataEN PersonEN = new PersonDataEN();
                            PersonEN.PersonId = personsIndex;
                            personsIndex++;
                            Console.WriteLine("enter name of customer");
                            PersonEN.PersonName = Console.ReadLine();
                            Console.WriteLine("enter mobileoperatorId : ");

                            PersonEN.MobileOperatorId = int.Parse(Console.ReadLine());
                            if (BLogics.ValidateMobileoperatorID(PersonEN.MobileOperatorId))
                            {
                                Console.WriteLine("vaid id");
                            }
                            else
                            {
                                throw new Exception("invalid id");
                            }
                            //
                            if (BLogics.AddPersionDataToTable((personsIndex - 1), PersonEN.PersonId, PersonEN.PersonName, PersonEN.MobileOperatorId))
                            {
                                Console.WriteLine("data added sucessfully ");
                            }
                            else
                            {
                                Console.WriteLine("somthning wrong");
                            }

                            break;
                        case 4:
                            if (personsIndex >= 0)
                            {
                                throw new Exception("there is no data");
                            }
                            else
                            {
                                Data = BLogics.DisplayPersonData();
                                while (Data.Read())
                                {

                                    Console.WriteLine($"{Data["PersonId"]}, {Data["personName"]}, {Data["mobileOperatorId"]}");
                                }
                                connection.CloseConnection();
                            }
                            break;
                        case 5:
                            if (mobileoperatorIndexer > 0)
                            {

                            }
                            else
                            {
                                throw new Exception("there is no data in table");
                            }
                            break;
                        case 7:
                            Console.WriteLine("exiting....\ndone.");
                            check = false;
                            break;
                        default:
                            Console.WriteLine("enter valid option");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }


            } while (check);
           
            Console.ReadLine();




        }
    }
}
