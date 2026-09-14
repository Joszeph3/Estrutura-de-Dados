using System;
using System.Collections.Generic;

class TesteLista
{
    static void Main()
    {
        List<string> linguagens = new List<string>
        {
            "Java",
            "Python",
            "C#"
        };
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Lista inicial:");
        Console.WriteLine(string.Join(", ", linguagens));
        Console.WriteLine("-------------------------------------------------");

        // Adicionando um elemento
        linguagens.Add("JavaScript");

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Após adicionar:");
        Console.WriteLine(string.Join(", ", linguagens));
        Console.WriteLine("-------------------------------------------------");

        // Removendo um elemento
        linguagens.Remove("Java");

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Após remover:");
        Console.WriteLine(string.Join(", ", linguagens));
        Console.WriteLine("-------------------------------------------------");

        /*
           Neste teste, criei uma lista de linguagens de programação utilizando List<string>. 
           O método Add() foi usado para adicionar um novo elemento à lista e o Remove() para remover um elemento
           Também utilizei string.Join() para exibir todos os itens da lista juntos no console
           
        */

    }
}