using System;

namespace verificaAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            String usuario;
            Console.WriteLine("Informa seu usuário");
            usuario = Console.ReadLine().ToUpper();

            if (!(usuario == "ADMINISTRADOR"))

            {
                Console.WriteLine("Atenção, este usuário não tem poderes administrativos e algumas tarefas serão bloqueadas");
            }
            else
            {
                Console.WriteLine("Seja bem vindo Administrador");
            }
        }
    }
}
