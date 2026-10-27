using System.Timers;

Console.WriteLine("Insira sua idade:");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Voce e estudante?");
char estudante = char.Parse(Console.ReadLine());
Console.WriteLine("Qual e o dia da semana?");
int diaSemana = int.Parse(Console.ReadLine());
Console.WriteLine("Aa secao e em 3d?");
char sesao = char.Parse(Console.ReadLine());
int ingresso = 40;
int meia = ingresso / 2;
double terca = 0.20;

if (idade < 12 || idade >= 60 || estudante == 's')
{
    Console.WriteLine($"O preco da meia do ingresso sera de {(ingresso / 2)}");
    if (diaSemana == '3')
    {
        Console.WriteLine($"O preco da meia de terca sera de: {(meia * 0.20) + meia}");
        if (sesao == 's')
        {
            Console.WriteLine($"O preco da meia de terca 3d sera de : {(meia * terca) + meia + 8}");
        }
    }
}
else if (diaSemana == '3')
{
    Console.WriteLine($"O preco do ingresso de terca sera de {(ingresso + 0.20) + ingresso}");
    if (sesao == 's')
    {
        Console.WriteLine($"O preco do ingresso de terca 3d sera de {(ingresso * terca) + ingresso + terca}");
    }
} else if (sesao == 's')
{
    Console.WriteLine($"O preco do ingresso 3d sera de {ingresso + 9}");
}
else if (idade < 0 || idade > 100)
{
    Console.WriteLine("Idade invalida");
}
else if (diaSemana < 1 || diaSemana > 7)
{
    Console.WriteLine("Dia invalido");
}
else
{
    Console.WriteLine($"O preco do ingresso sera de {ingresso}");
}

       
