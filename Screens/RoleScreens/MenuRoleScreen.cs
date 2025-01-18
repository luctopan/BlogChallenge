namespace BlogChallenge.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("GESTÃO DE PERFIS");
            Console.WriteLine("----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1. Listar perfis");
            Console.WriteLine("2. Cadastrar perfil");
            Console.WriteLine("3. Atualizar perfil");
            Console.WriteLine("4. Excluir perfil");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    Load();
                    break;
                case 2:
                    Load();
                    break;
                case 3:
                    Load();
                    break;
                case 4:
                    Load();
                    break;
                case 0:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}