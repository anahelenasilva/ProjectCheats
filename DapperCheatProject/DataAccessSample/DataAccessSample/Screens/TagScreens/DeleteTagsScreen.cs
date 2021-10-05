using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessSample.Models;
using DataAccessSample.Repositories;

namespace DataAccessSample.Screens.TagScreens
{
    public static class DeleteTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete tag");
            Console.WriteLine("--------------------");

            Console.WriteLine("Id para excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();

            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag deletada com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
