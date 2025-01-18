using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE USUÁRIOS:");
            Console.WriteLine("------------------");
            List();
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var item in users)
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Email} ({item.Slug})");
        }
    }
}