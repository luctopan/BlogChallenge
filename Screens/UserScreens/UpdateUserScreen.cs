using BlogChallenge.Models;
using BlogChallenge.Repositories;

namespace BlogChallenge.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("ATUALIZAR USUÁRIO");
            Console.WriteLine("-----------------");

            Console.Write("Digite o Id do usuário que deseja atualizar: ");
            var id = Console.ReadLine();

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

            Update(new User
            {
                Id = int.Parse(id),
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

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine();
                Console.WriteLine("Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}