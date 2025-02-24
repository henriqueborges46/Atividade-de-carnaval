// See https://aka.ms/new-console-template for more information

using System;

static void Main(string[] args)
{


Console.WriteLine("Digite a quantidade media de vendas mensais:");
int vendasmedia = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o preço atual do produto:");
    decimal precoatual = decimal.Parse(Console.ReadLine());

   decimal novopreco = Reajustarpreco([vendasmedia, precoatual]);
    Console.WriteLine($"O novo preço do produto é: R$ {novopreco:F2}");
}
static decimal Reajustarpreco(int vendasmedia, decimal precoatual);
{
    decimal novopreco = precoatual;

    if (vendasmedia < 500 && precoatual < 30.00m)
    {
        novopreco = precoatual + (0.10m * precoatual);
    }
    else if (vendasmedia >= 500 && precoatual >= 30.00m)
    {
        novopreco = precoatual - (0.20m * precoatual);
    }
    return novopreco;
 }





