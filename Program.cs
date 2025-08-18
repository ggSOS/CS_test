// See https://aka.ms/new-console-template for more information
namespace Ambiente1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dois números serão somados, e resultado será comparado a zero.");

            Console.Write("Digite o primeiro número a ser somado:\n\t- ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número a ser somado:\n\t- ");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = n1 + n2;
            String resultado;
            if (n3 < 0)
            {
                resultado = "menor";
            }else if (n3 == 0)
            {
                resultado = "igual";
            }
            else
            {
                resultado = "maior";
            }
            Console.Write("A soma ({0}) é {1} que zero", n3, resultado);
        }
    }
}