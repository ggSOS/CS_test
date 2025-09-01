namespace Ambiente1
{
    internal class Program
    {
        /// <summary>
        /// Funcao que calcula soma de inteiros
        /// </summary>
        /// <param name="Number1"> Primeiro Inteiro </param>
        /// <param name="Number2"> Segundo Inteiro </param>
        /// <returns> int result </returns>
        static int AddNumbers(int Number1, int Number2)
        {
            int result = Number1 + Number2;
            return result;
        }
        /// <summary>
        /// Funcao que calcula soma de Grandes Pontos Flutuantes
        /// </summary>
        /// <param name="Number1"> Primeiro Grande Ponto Flutuante </param>
        /// <param name="Number2"> Segundo Grande Ponto Flutuante </param>
        /// <returns> Double result </returns>
        static Double AddNumbers(Double Number1, Double Number2)
        {
            Double result = Number1 + Number2;
            return result;
        }


        /// <summary>
        /// Funcao para cumprimentar um usuário
        /// </summary>
        /// <param name="UserName"> Nome do usuario </param>
        static void Salutation(String UserName)
        {
            Console.WriteLine(" Ola, {0}. Bem-vindo!", UserName);
            return;
        }


        /// <summary>
        /// Funcao que calcula Area de Retangulos
        /// </summary>
        /// <param name="Length"> Comprimento do retangulo </param>
        /// <param name="Width"> Largura do retangulo </param>
        /// <returns> Double area </returns>
        static Double CalculateRectangleArea(Double Length, Double Width)
        {
            Double area = Length * Width;
            return area;
        }


        /// <summary>
        /// Funcao que calcula area de retangulos
        /// </summary>
        /// <param name="Base"> Base do triangulo </param>
        /// <param name="Height"> Altura do triangulo </param>
        /// <returns> Double area </returns>
        static Double CalculateTriangleArea(Double Base, Double Height)
        {
            Double area = Base * Height / 2;
            return area;
        }


        /// <summary>
        /// Funcao que calcula a multiplicacao de dois inteiros
        /// </summary>
        /// <param name="Number1"> Primeiro inteiro </param>
        /// <param name="Number2"> Segundo inteiro </param>
        /// <returns> int Result </returns>
        static int Multiply(int Number1, int Number2)
        {
            int Result = Number1 * Number2;
            return Result;
        }
        /// <summary>
        /// Funcao que calcula a multiplicacao de dois grandes flutuantes
        /// </summary>
        /// <param name="Number1"> Primeiro grande flutuante </param>
        /// <param name="Number2"> Segundo grande flutuante </param>
        /// <returns> Double Result </returns>
        static Double Multiply(Double Number1, Double Number2)
        {
            Double Result = Number1 * Number2;
            return Result;
        }


        public static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            Double num5 = 5.0;
            Double num6 = 6.0;
            Double num7 = 7.0;
            Double num8 = 8.0;
            Console.WriteLine(" A soma do Inteiro {0} com o Inteiro {1} resulta no Inteiro {2}", num1,
                num2, AddNumbers(num1, num2));
            Console.WriteLine(" A soma do Inteiro {0} com o Inteiro {1} resulta no Inteiro {2}", num3,
                num4, AddNumbers(num3, num4));
            Console.WriteLine(" A soma do Grande Ponto Flutuante {0} com o Grande Ponto Flutuante {1} " +
                "resulta no Grande Ponto Flutuante {2}", num5, num6, AddNumbers(num5, num6));
            Console.WriteLine(" A soma do Grande Ponto Flutuante {0} com o Grande Ponto Flutuante {1} " +
                "resulta no Grande Ponto Flutuante {2}", num7, num8, AddNumbers(num7, num8));


            Console.WriteLine();
            Salutation("Leticio");
            Salutation("Serjo");


            double measure1 = 5;
            double measure2 = 6;
            double measure3 = 7;
            double measure4 = 8;
            double measure5 = 9;
            double measure6 = 10;
            double measure7 = 11;
            double measure8 = 12;
            Console.WriteLine();
            Console.WriteLine(" Um Retangulo de comprimento {0} e largura {1} possui " +
                "area {2}", measure1, measure2, CalculateRectangleArea(measure1, measure2));
            Console.WriteLine(" Um Retangulo de comprimento {0} e largura {1} possui " +
                "area {2}", measure3, measure4, CalculateRectangleArea(measure3, measure4));
            Console.WriteLine(" Um Triangulo de base {0} e altura {1} possui " +
                "area {2}", measure5, measure6, CalculateTriangleArea(measure5, measure6));
            Console.WriteLine(" Um Triangulo de base {0} e altura {1} possui " +
                "area {2}", measure7, measure8, CalculateTriangleArea(measure7, measure8));


            Console.WriteLine();
            Console.WriteLine(" A multiplicacao do Inteiro {0} pelo o Inteiro {1} resulta " +
                "no Inteiro {2}", num1, num2, Multiply(num1, num2));
            Console.WriteLine(" A multiplicacao do Inteiro {0} pelo o Inteiro {1} resulta " +
                "no Inteiro {2}", num3, num4, Multiply(num3, num4));
            Console.WriteLine(" A multiplicacao do Grande Ponto Flutuante {0} pelo o Grande " +
                "Ponto Flutuante {1} resulta no Grande Ponto Flutuante {2}", num5, num6,
                Multiply(num5, num6));
            Console.WriteLine(" A multiplicacao do Grande Ponto Flutuante {0} pelo o Grande " +
                "Ponto Flutuante {1} resulta no Grande Ponto Flutuante {2}", num7, num8,
                Multiply(num7, num8));


            // impedir fechamento automático do console
            Console.Write("\n Aperte Enter para finalizar o programa");
            Console.ReadLine();
        }
    }
}