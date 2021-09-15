using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            string bas,altura;
            Console.WriteLine(" ");
            Console.WriteLine(@"Olá usuário, seja bem vindo!
Esse programa irá calcular a área de um triangulo reto com as medidas que você fornecer!");
            
            Console.Write("Valor da base: ");
            bas = Console.ReadLine();
            
            Console.Write("Valor da altura: ");
            altura = Console.ReadLine();

            double b = Convert.ToDouble(bas);
            double h = Convert.ToDouble(altura);

            Console.WriteLine($"Área: {b * h / 2}");

            Console.WriteLine(@"Espero que tenha gostado! 
Até Mais!");

        }
    }
}
