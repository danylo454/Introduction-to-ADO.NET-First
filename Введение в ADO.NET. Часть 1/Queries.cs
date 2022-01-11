using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Введение_в_ADO.NET._Часть_1
{
    public class Queries
    {
        public static void Task1(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM VegetablesAnDFruit";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
                    }
                    Console.WriteLine(new string('_', 30));
                }
            }
            reader.Close();
        }
        public static void Task2(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Name From VegetablesAnDFruit";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0 ;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    a = a + 1;
                    Console.WriteLine(a + ")" + reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void Task3(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Color From VegetablesAnDFruit";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    a = a + 1;
                    Console.WriteLine(a + ")" + reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void Task4(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT MAX(Calorie) From VegetablesAnDFruit";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine("Max Calorie: " + reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void Task5(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Min(Calorie) From VegetablesAnDFruit";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine("Min Calorie: " + reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void Task6(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT AVG(Calorie) From VegetablesAnDFruit";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine("AVG Calories: " + reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void CountVegetables(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Count(*) From VegetablesAnDFruit where Type = 'Vegetable'";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine("Count Vegetable: " + reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void CountFruit(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Count(*) From VegetablesAnDFruit where Type = 'Fruit'";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine("Count fruit: " + reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void CountVegetablesOrFruitByColor(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            Console.Write("Enter Color: ");
            string color = Console.ReadLine();
            cmd.CommandText = $"SELECT * From VegetablesAnDFruit where Color = '{color}'";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void CountAllColor(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT Color,Type, COUNT(*) FROM VegetablesAnDFruit GROUP BY Color,Type";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void SelectCaloriesLower(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            Console.Write("Enter calories < : ");
            string cal = Console.ReadLine();
            cmd.CommandText = $"SELECT * FROM VegetablesAnDFruit where Calorie < {cal}";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void SelectCaloriesHigher(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            Console.Write("Enter calories > : ");
            string cal = Console.ReadLine();
            cmd.CommandText = $"SELECT * FROM VegetablesAnDFruit where Calorie > {cal}";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void SelectCaloriesBETWEEN(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            Console.Write("Enter calories first : ");
            string cal = Console.ReadLine();
            Console.Write("Enter calories second : ");
            string cal2 = Console.ReadLine();
            cmd.CommandText = $"SELECT * FROM VegetablesAnDFruit WHERE Calorie BETWEEN {cal} AND {cal2};";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
        public static void SelectCaloriesRedOrYellow(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM VegetablesAnDFruit WHERE Color='Red' or  Color='Yellow' ";
            SqlDataReader reader = cmd.ExecuteReader();
            int a = 0;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
                }
                Console.WriteLine(new string('_', 30));
            }
            reader.Close();
        }
    }
}
