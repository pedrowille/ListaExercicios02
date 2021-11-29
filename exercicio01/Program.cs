using System;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
int maiorDezoito = 0;
List<int> idades = new ();
for (int i=1; i<=10; i++)                
        {
            Console.WriteLine($"Informe a idade da pessoa número {i}");
        idades.Add(Convert.ToInt32(Console.ReadLine()));
        }
foreach (int i in idades)
{
    if (i>=18)
    {
        maiorDezoito++;
    }
}
Console.WriteLine($"{maiorDezoito} pessoas tem mais de dezoito anos.");
        }
    }
}