using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("NOVO USUÁRIO");
            Console.WriteLine("------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Senha: ");
            var password = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Imagem de perfil: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine();
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar o usuário.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}