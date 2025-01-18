using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("ATUALIZAR CATEGORIA");
            Console.WriteLine("-----------------");

            Console.Write("Digite o Id da categoria que deseja atualizar: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine();
                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a categoria.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}