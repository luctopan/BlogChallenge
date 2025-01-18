using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE CATEGORIAS:");
            Console.WriteLine("-------------------");
            List();
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();
            foreach (var item in categories)
                Console.WriteLine($"{item.Id} - {item.Name} - ({item.Slug})");
        }
    }
}