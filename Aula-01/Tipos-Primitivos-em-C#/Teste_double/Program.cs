Console.WriteLine("Digite a primeira nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
double nota3 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("Nota 1: " + nota1);
Console.WriteLine("Nota 2: " + nota2);
Console.WriteLine("Nota 3: " + nota3);
Console.WriteLine("Média: " + media);

if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}
