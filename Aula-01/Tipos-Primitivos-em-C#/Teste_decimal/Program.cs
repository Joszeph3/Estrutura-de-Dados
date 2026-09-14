decimal precoProduto = 1299.90m;
decimal desconto = 150.50m;
decimal frete = 25.90m;

decimal precoFinal = precoProduto - desconto + frete;

Console.WriteLine("Preço do produto: " + precoProduto);
Console.WriteLine("Desconto: " + desconto);
Console.WriteLine("Frete: " + frete);
Console.WriteLine("Preço final: " + precoFinal);

if (precoFinal > 1000m)
{
    Console.WriteLine("Compra de alto valor.");
}
else
{
    Console.WriteLine("Compra de baixo valor.");
}