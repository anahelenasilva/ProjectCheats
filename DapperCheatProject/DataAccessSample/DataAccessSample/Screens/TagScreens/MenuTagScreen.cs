using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessSample.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Tags");
            Console.WriteLine("2 - Cadastrar Tag");
            Console.WriteLine("3 - Atualizar Tags");
            Console.WriteLine("4 - Excluir Tags");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListTagsScreen.Load();
                    break;
                case 2:
                    CreateTagsScreen.Load();
                    break;
                case 3:
                    UpdateTagsScreen.Load();
                    break;
                case 4:
                    DeleteTagsScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
