long populacaoBrasil = 213000000;
long populacaoMundial = 8100000000;

long diferenca = populacaoMundial - populacaoBrasil;

Console.WriteLine("População do Brasil: " + populacaoBrasil);
Console.WriteLine("População mundial: " + populacaoMundial);
Console.WriteLine("Diferença: " + diferenca);

if (populacaoMundial > populacaoBrasil)
{
    Console.WriteLine("A população mundial é maior que a população do Brasil.");
}