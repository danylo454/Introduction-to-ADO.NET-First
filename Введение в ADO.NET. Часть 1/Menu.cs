using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Введение_в_ADO.NET._Часть_1
{
    public class Menu
    {
        private string connectionString = @"Data Source=DESKTOP-PFI6MSV\SQLEXPRESS;Initial Catalog=VegetablesAndFruit; Integrated Security=True;TrustServerCertificate=True;";
        public static void Start()
        {
            int input = -1;
            do
            {
                Console.Write($"\n1)Display of all information from the table with vegetables and fruits;\n" +
                    $"2)Display of all the names of vegetables and fruits\n" +
                    $"3)Display all colors\n" +
                    $"4)Show the maximum calorie content\n" +
                    $"5)Show minimum calorie content\n" +
                    $"6)Show average calorie content\n" +
                    $"7)Show the amount of vegetables\n" +
                    $"8)Show the amount of fruit\n" +
                    $"9)Show the amount of vegetables and fruits given colors\n" +
                    $"10)Show the amount of vegetables and fruits of each color\n" +
                    $"11)Show vegetables and fruits with calories below specified\n" +
                    $"12)Show vegetables and fruits with higher calories indicated\n" +
                    $"13)Show vegetables and fruits with calories in the specified range\n" +
                    $"14)Show all fruits and vegetables that are yellow or red \n" +
                    $"0)Exit" +
                    $"Enter: ");
                input = int.Parse(Console.ReadLine());
                Console.Clear();
                string connectionString = @"Data Source=DESKTOP-PFI6MSV\SQLEXPRESS;Initial Catalog=VegetablesAndFruit; Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        switch (input)
                        {
                            case 1: { Queries.Task1(connection); break; }
                            case 2: { Queries.Task2(connection); break; }
                            case 3: { Queries.Task3(connection); break; }
                            case 4: { Queries.Task4(connection); break; }
                            case 5: { Queries.Task5(connection); break; }
                            case 6: { Queries.Task6(connection); break; }
                            case 7: { Queries.CountVegetables(connection); break; }
                            case 8: { Queries.CountFruit(connection); break; }
                            case 9: { Queries.CountVegetablesOrFruitByColor(connection); break; }
                            case 10: { Queries.CountAllColor(connection); break; }
                            case 11: { Queries.SelectCaloriesLower(connection); break; }
                            case 12: { Queries.SelectCaloriesHigher(connection); break; }
                            case 13: { Queries.SelectCaloriesBETWEEN(connection); break; }
                            case 14: { Queries.SelectCaloriesRedOrYellow(connection); break; }
                            case 0: { Console.Clear(); input = 0; break; }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            } while (input != 0);
            Console.Clear();
        }

    }
}
