using BlogChallenge.Screens.CategoryScreens;
using BlogChallenge.Screens.RoleScreens;
using BlogChallenge.Screens.TagScreens;
using BlogChallenge.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace BlogChallenge
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            Console.Clear();

            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("MEU BLOG");
            Console.WriteLine("-------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1. Gestão de usuários");
            Console.WriteLine("2. Gestão de perfis");
            Console.WriteLine("3. Gestão de categorias");
            Console.WriteLine("4. Gestão de tags");
            Console.WriteLine("5. Gestão de posts");
            Console.WriteLine("6. Vincular perfil/usuário");
            Console.WriteLine("7. Vincular post/tag");
            Console.WriteLine("8. Relatórios");
            Console.WriteLine();
            Console.WriteLine("0. Sair");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    // gestão de posts
                    break;
                case 6:
                    // vincular perfil/usuário
                    break;
                case 7:
                    // vincular post/tag
                    break;
                case 8:
                    // relatórios
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default: Load(); break;
            }
        }

    }
}