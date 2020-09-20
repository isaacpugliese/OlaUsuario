using System;

namespace olausuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por Favor Digite seu Nome: ");
            string NmUsuario = Console.ReadLine();
            Console.Clear();
            Console.Write("Olá, ");
            Console.WriteLine(NmUsuario);
        }
    }
}
