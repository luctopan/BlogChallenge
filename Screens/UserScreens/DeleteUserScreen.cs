using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("EXCLUIR USUÁRIO");
            Console.WriteLine("---------------");

            Console.Write("Digite o Id do usuário que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine();
                Console.WriteLine("Usuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o usuário.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}