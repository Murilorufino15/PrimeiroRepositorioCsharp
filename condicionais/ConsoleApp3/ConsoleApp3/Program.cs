Console.WriteLine(" limite da via");
int limite = int.Parse(Console.ReadLine());

Console.WriteLine("Velocidade media:");
int velocidade = int.Parse(Console.ReadLine()!);

if (limite < 0 || velocidade < 0)
{
    Console.WriteLine("Dados sao invalidos");
    return;
}

double percentual = (velocidade - limite) * 100 / limite;

/// ////////// ultilizando switch expression

string classificacao = percentual switch
{
    <= 0 => "Dentro do Limite",
    <= 20 => "Infracao Media",
    <= 50 => "Infracao Grave",
    _ => "Infracao Gravissima"
};
if (percentual <= 0)
{
    Console.WriteLine(classificacao);
}
else
{
    Console.WriteLine($"{percentual:f2} acima  : {classificacao}");
}