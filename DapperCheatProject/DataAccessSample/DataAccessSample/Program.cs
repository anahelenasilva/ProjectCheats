using System;
using Dapper;
using Dapper.Contrib.Extensions;
using DataAccessSample.Models;
using DataAccessSample.Repositories;
using Microsoft.Data.SqlClient;

namespace DataAccessSample
{
    class Program
    {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();

            ReadUsers(connection);
            ReadRoles(connection);

            //ReadUsers();
            //ReadUser();
            //CreateUser();
            //UpdateUser();
            //DeleteUser();
            //ReadUsers();

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var users = repository.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var roles = repository.GetAll();
            foreach (var role in roles)
            {
                Console.WriteLine(role.Name);
            }
        }

        public static void CreateUser()
        {
            var user = new User
            {
                Name = "Ana Two",
                Bio = "bla bla bla",
                Email = "twaaaaaaao@ana.com",
                Image = "image.com",
                PasswordHash = "34564654546",
                Slug = "ana-two-sdfsdf"
            };

            using var connection = new SqlConnection(connectionString);
            {
                connection.Insert<User>(user);
                Console.WriteLine("Create Success");
            }
        }

        public static void UpdateUser()
        {
            var user = new User
            {
                Id = 2,
                Name = "Ana Two Two",
                Bio = "bla bla bla",
                Email = "fdsfdsfds@ana.com",
                Image = "image.com",
                PasswordHash = "34564654546",
                Slug = "ana-two-sdfsdf"
            };

            using var connection = new SqlConnection(connectionString);
            {
                connection.Update<User>(user);
                Console.WriteLine("Update Success");
            }
        }

        public static void DeleteUser()
        {

            using var connection = new SqlConnection(connectionString);
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine("Delete Success");
            }
        }
    }
}
