using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("EXCLUIR CATEGORIA");
            Console.WriteLine("-----------------");

            Console.Write("Digite a Id da categoria que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine();
                Console.WriteLine("Categoria excluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a categoria.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}