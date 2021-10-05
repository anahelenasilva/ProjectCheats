using DataAccessSample.Models;
using DataAccessSample.Repositories;
using System;

namespace DataAccessSample.Screens.TagScreens
{
    public static class ListTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("--------------------");

            List();
            Console.ReadKey();

            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.GetAll();

            foreach (var tag in tags)
            {
                Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");
            }
        }
    }
}
