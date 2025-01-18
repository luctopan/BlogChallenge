using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("NOVA CATEGORIA");
            Console.WriteLine("--------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine();
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar a categoria.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}