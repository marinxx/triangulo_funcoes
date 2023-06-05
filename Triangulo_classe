using System;
using System.Globalization;
//agrupamento e organizaçao de classes
namespace Course
{
    //classe triangulo
    public class Triangulo
    {
        //variaveis que representam os lados do triangulo
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        //metodo e formula para calcular a area do triangulo
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }
    //classe program
    public class Program
    {
        public static void Main(string[] args)
        {
            //duas variaveis da classe sao criadas para identificar cada triangulo
            // lertriangulo para ler as medidas, solicita que o usuario do programa insira as medidas de cada lado dos triagulos
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");
            //calcula a area dos dois triangulos
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();
            //exibe a area dos triangulos, com valores de 4 casas decimais por F4
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //exibe qual traingulo tem a maior e menor area
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            Triangulo triangulo = new Triangulo();
            //mensagem exibida para o usuario
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return triangulo;
        }
    }
}
