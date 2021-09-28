using System;
using Dapper;
using DataAccessSample.Models;
using Microsoft.Data.SqlClient;

namespace DataAccessSample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=PWD";

            using var connection = new SqlConnection(connectionString);
            var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Id} - {category.Title}");
            }


            Console.WriteLine("Hello World!");
        }
    }
}
