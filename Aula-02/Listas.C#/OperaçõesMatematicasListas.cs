using System;
using System.Collections.Generic;
using System.Linq;

class TesteNumeros
{
    static void Main()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40 };

        int soma = numeros.Sum();
        int maior = numeros.Max();
        int menor = numeros.Min();

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Números:");
        Console.WriteLine(string.Join(", ", numeros));
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Maior número: " + maior);
        Console.WriteLine("Menor número: " + menor);
        Console.WriteLine("---------------------------------");

        /*
         Neste teste, criei uma lista de números inteiros utilizando List<int>. 
         Usei o método Sum() para somar todos os números da lista, Max() para encontrar o maior valor e Min() para encontrar o menor valor.
        
        */
    }
}