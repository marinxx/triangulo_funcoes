using System;
using System.Globalization;
//agrupando e organizando classes
namespace Course
{
//classe program
    public class Program
    {
//começo do programa
        public static void Main(string[] args)
        {
//dois arrays criados para identificar as medidas dos triangulos
//funçao lermedidastriangulo para ler as medidas, solicita que o usuario do programa insira as medidas de cada lado dos triagulos
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");
//funçao para calcular a area dos triangulos
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);
//exibe as areas calculadas
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
//compara as duas areas para ver qual é maior e qual é menor
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
//string para identificar o nome do triangulo (X ou Y)
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            double[] medidas = new double[3];
//mensagemque aparece na tela do usuario
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            for (int i = 0; i < 3; i++)
            {
//transforma as medidas em double com double.parse
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            return medidas;
        } 

        public static double CalcularAreaTriangulo(double[] medidas)
        {
//cada variavel seria a medida de cada lado do triangulo
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];
//formula que calcula a area
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * ( p - c));

            return area;
        }
    }
}
