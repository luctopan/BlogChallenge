using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("EXCLUIR TAG");
            Console.WriteLine("-----------");

            Console.Write("Digite o Id da tag que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine();
                Console.WriteLine("Tag excluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}