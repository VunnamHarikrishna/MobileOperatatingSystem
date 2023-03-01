using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DLL
    {
        public bool AddMobileDataToTable(int i,int mobileOperatorId, string mobileOperatorName, int mobileOperatorRating)
        {
            ConnectionToDataBase connection = new ConnectionToDataBase();

            if (i == 0)
            {
                connection.OpenConnection();
                SqlCommand cm = new SqlCommand("drop table MobileOperators;", connection.getConnection());
                cm.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("CREATE TABLE MobileOperators( MobileOperatorId int, MobileOperatorName varchar(15),MobileOperatorRating int);", connection.getConnection());
                command.ExecuteNonQuery();
                Console.WriteLine("table created . ");
                command = new SqlCommand($"insert into MobileOperators values({mobileOperatorId},'{mobileOperatorName}',{mobileOperatorRating});", connection.getConnection());
                command.ExecuteNonQuery();
                Console.WriteLine("data inserted. into table");
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.OpenConnection();
                SqlCommand command = new SqlCommand($"insert into MobileOperators values({mobileOperatorId},'{mobileOperatorName}',{mobileOperatorRating});", connection.getConnection());
                command.ExecuteNonQuery();
                Console.WriteLine("data inserted. into table");
                connection.CloseConnection();
                return true;
            }
        }

        public SqlDataReader GetPersonsData()
        {
            ConnectionToDataBase connection = new ConnectionToDataBase();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("select * from PersonsData;", connection.getConnection());
            SqlDataReader Returningdata = command.ExecuteReader();
            return Returningdata;
        }

        public bool AddPersonDataToTable(int personsIndex, int personId, string personName, int mobileOperatorId)
        {
            ConnectionToDataBase connection = new ConnectionToDataBase();
            if (personsIndex == 0)
            {
                connection.OpenConnection();
                SqlCommand cm = new SqlCommand("drop table PersonsData;", connection.getConnection());
                cm.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("CREATE TABLE PersonsData( PersonId int, personName varchar(15),mobileOperatorId int);", connection.getConnection());
                command.ExecuteNonQuery();
                Console.WriteLine("table created . ");
                command = new SqlCommand($"insert into PersonsData values({personId},'{personName}',{mobileOperatorId});", connection.getConnection());
                command.ExecuteNonQuery();
                Console.WriteLine("data inserted. into table");
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.OpenConnection();
                SqlCommand command = new SqlCommand($"insert into PersonsData values({personId},'{personName}',{mobileOperatorId});", connection.getConnection());
                command.ExecuteNonQuery();
                Console.WriteLine("data inserted. into table");
                connection.CloseConnection();
                return true;
            }
        }

        public SqlDataReader GetMobileOperatorsData()
        {
            ConnectionToDataBase connection = new ConnectionToDataBase();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("select * from MobileOperators;", connection.getConnection());
            SqlDataReader Returningdata = command.ExecuteReader();
            //while (Returningdata.Read())
            //{
            //    Console.WriteLine($"{Returningdata["MobileOperatorId"]}, {Returningdata["MobileOperatorName"]}, {Returningdata["MobileOperatorRating"]}");
            //}
            return Returningdata;
        }



        //public bool AddDataToTable(int i, int mobileOperatorId, string mobileOperatorName, int mobileOperatorRating)
        //{
        //    ConnectionToDataBase Entitesconnection = new ConnectionToDataBase();
        //    if (i == 0)
        //    {
        //        Entitesconnection.OpenConnection();
        //        SqlCommand cm = new SqlCommand("drop table MobileOperators;", Entitesconnection.getConnection());              
        //        cm.ExecuteNonQuery();
        //        SqlCommand command = new SqlCommand("CREATE TABLE MobileOperators( MobileOperatorId int, MobileOperatorName varchar(15),MobileOperatorRating int);", Entitesconnection.getConnection());
        //        command.ExecuteNonQuery();
        //        Console.WriteLine("table created . ");
        //        command = new SqlCommand($"insert into MobileOperators values({mobileOperatorId},'{mobileOperatorName}',{mobileOperatorRating});", Entitesconnection.getConnection());
        //        command.ExecuteNonQuery();
        //        Console.WriteLine("data inserted. into table");
        //        Entitesconnection.CloseConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        Entitesconnection.OpenConnection();
        //        SqlCommand command = new SqlCommand($"insert into MobileOperators values({mobileOperatorId},'{mobileOperatorName}',{mobileOperatorRating});", Entitesconnection.getConnection());
        //        command.ExecuteNonQuery();
        //        Console.WriteLine("data inserted. into table");
        //        Entitesconnection.CloseConnection();
        //        return true;
        //    }   
        //    return false;
        //}

        //public SqlDataReader GetPersonsData()
        //{
        //    ConnectionToDataBase Entitesconnection = new ConnectionToDataBase();
        //    Entitesconnection.OpenConnection();
        //    SqlCommand command = new SqlCommand("select * from PersonsData;", Entitesconnection.getConnection());
        //    SqlDataReader Returningdata = command.ExecuteReader();
        //    return Returningdata;
        //}

        //public bool AddPersionDataToTable(int PersonId, string personName, int mobileOperatorId)
        //{
        //    EntitiesClass Entitesconnection = new EntitiesClass();
        //    if (PersonId == 1)
        //    {
        //        Entitesconnection.OpenConnection();
        //        SqlCommand cm = new SqlCommand("drop table PersonsData;", Entitesconnection.getConnection());
        //        cm.ExecuteNonQuery();
        //        SqlCommand command = new SqlCommand("CREATE TABLE PersonsData( PersonId int, personName varchar(15),mobileOperatorId int);", Entitesconnection.getConnection());
        //        command.ExecuteNonQuery();
        //        Console.WriteLine("table created . ");
        //        command = new SqlCommand($"insert into PersonsData values({PersonId},'{personName}',{mobileOperatorId});", Entitesconnection.getConnection());
        //        command.ExecuteNonQuery();
        //        Console.WriteLine("data inserted. into table");
        //        Entitesconnection.CloseConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        Entitesconnection.OpenConnection();
        //        SqlCommand command  = new SqlCommand($"insert into PersonsData values({PersonId},'{personName}',{mobileOperatorId});", Entitesconnection.getConnection());
        //        command.ExecuteNonQuery();
        //        Console.WriteLine("data inserted. into table");
        //        Entitesconnection.CloseConnection();
        //        return true;
        //    }
        //    return false;
        //}

        //public SqlDataReader GetMobileOperatorsData()
        //{
        //    EntitiesClass Entitesconnection = new EntitiesClass();
        //    Entitesconnection.OpenConnection();
        //    SqlCommand command = new SqlCommand("select * from MobileOperators;", Entitesconnection.getConnection());
        //    SqlDataReader Returningdata= command.ExecuteReader();
        //    //while (Returningdata.Read())
        //    //{
        //    //    Console.WriteLine($"{Returningdata["MobileOperatorId"]}, {Returningdata["MobileOperatorName"]}, {Returningdata["MobileOperatorRating"]}");
        //    //}
        //     return Returningdata;

        //}

    }
}
//SqlCommand command = new SqlCommand("IF EXISTS(SELECT * FROM Sample)SELECT 1 ELSE SELECT 0; ", Entitesconnection.getConnection());
//if (command.ExecuteNonQuery() == 1)
//{
//}