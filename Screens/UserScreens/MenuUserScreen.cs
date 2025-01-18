namespace BlogChallenge.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("GESTÃO DE USUÁRIOS");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1. Listar usuários");
            Console.WriteLine("2. Cadastrar usuário");
            Console.WriteLine("3. Atualizar usuário");
            Console.WriteLine("4. Excluir usuário");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                case 0:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}