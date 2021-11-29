using System;
using System.Collections.Generic;
using System.Linq;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Programa calcula soma dos quadrados:\nInforme um número inteiro entre 10 e 0:");
int num = 0;
bool val=true;
while (val==true)
{
try
{
num = Convert.ToInt32(Console.ReadLine());
if (num >0 && num <=10)
val=false;
else
throw new Exception();
}
catch
{
    Console.WriteLine("Valor inválido.");
}
}
List<int> listaNumeros = new List<int>();
List<int> listaQuadrados = new List<int>();
int resultado = 0;
if (num %2==0)
listaNumeros.Add(num+1);
else
listaNumeros.Add(num);

for (int i=1; i<20; i++)
{
    listaNumeros.Add(listaNumeros.Last()+2);
}
for (int i=0; i<20; i++)
{
listaQuadrados.Add(calculaQuadrado(listaNumeros[i]));
resultado = resultado + listaQuadrados[i];
}
Console.WriteLine($"O resultado da soma dos quadrados à partir do número inicial é: {resultado}");
}
static int calculaQuadrado(int n)
{
    return n*n;
        }
    }
}