using System;
using System.Collections.Generic;

using System.Linq;
namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa calcula média das notas de uma turma:\nDigite 0 ou um número negativo para terminar.");
List<int> listaMatriculas = new List<int>();
List<double> listaNotas = new List<double>();
bool val=false;
while (val==false)
{
try
{
Console.WriteLine("Número de matrícula:");
listaMatriculas.Add(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Informe a nota do aluno:");
listaNotas.Add(Convert.ToDouble(Console.ReadLine()));
if (listaMatriculas.Last() <0 || listaNotas.Last() <0)
val=true;
}
catch
{
Console.WriteLine("Valor inválido.");
}
double notas = 0;
foreach (double n in listaNotas)
{
    notas = notas + n;
}
double media = notas / 2;
Console.WriteLine($"A média da turma é: {string.Format("{0:0.00}", media)}");


}
        }
    }
}