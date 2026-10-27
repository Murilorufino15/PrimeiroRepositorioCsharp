////// Estruturas conIdicioais
//using System.Globalization;

//Console.Write("Digite sua idade:");
//int idade = int.Parse(Console.ReadLine());
//Console.Write("Voce tem titulo de eleitor:");
//char possuit = char.Parse(Console.ReadLine());

//if (idade >= 18 && possuit == 's')
//{
//    Console.Write("Voce pode votar, o voto e obrigatorio");
//    if (possuit != 's')
//    {
//        Console.WriteLine("antes de votar voce deve tirar o titulo de eleitor");
//    }
//}
//else if (idade < 16)
//{
//    Console.Write("Voce nao pode votar");
//}
//else
////{
////    Console.Write("O voto e facultativo");
////}
/////////////////////////////////////////
////Console.WriteLine("Informe uma nota:");

////string notaInformada = Console.ReadLine();
////if (!double.TryParse(notaInformada, out double notaFinal))
////{
////    Console.WriteLine("Entrada invalida, tente novamente digitando outro numero!");
////}

////if (notaFinal <0 || notaFinal > 10)
////{
////    Console.WriteLine("Conceito A");
////}else if( notaFinal >= 7)
////{
////    Console.WriteLine("Conceito B");
////}else if(notaFinal >= 5)
////{
////    Console.WriteLine("Conceito C");
////}
////else
////{
////    Console.WriteLine("Conceito D");
////}




//Console.WriteLine("Insira sua idade:");
//int idade = int.Parse(Console.ReadLine());
//Console.WriteLine("Voce e estudante?");
//char estudante = char.Parse(Console.ReadLine());
//Console.WriteLine("Qual e o dia da semana?");
//int diaSemana = int.Parse (Console.ReadLine());
//Console.WriteLine("Aa secao e em 3d?");
//char sesao = char.Parse (Console.ReadLine());
//int ingresso = 40;
//int meia = ingresso / 2;
//double terca = 0.20;

//if (idade < 12 || idade >= 60 || estudante == 's')
//{
//    Console.WriteLine($"O preco da meia do ingresso sera de {(ingresso / 2)}");
//    if (diaSemana == '3')
//    {
//        Console.WriteLine($"O preco da meia de terca sera de {(meia * 0.20) + meia}");
//    }
//}
//if (diaSemana == '3')
//{
//    Console.WriteLine($"O preco do ingresso de terca sera de {(ingresso * 0.20) + ingresso}");
//    if (diaSemana == '3' || idade < 12 || idade >= 60 || estudante == 's')
//    {
//        Console.WriteLine($"O preco do ingresso de terca com meia sera de {(ingresso * 0.20) + meia}");
//    }
//}
//if (sesao == 's')
//{
//    Console.WriteLine($"O preco do ingresso 3d sera de {ingresso + 8}");
//    if (sesao == 's' || idade < 12 || idade >= 60 || estudante == 's')
//    {
//        Console.WriteLine($"O preco do ingresso 3d estudante sera de {(ingresso / 2) + 8}");
//        if (sesao == 's' || idade < 12 || idade >= 60 || estudante == 's' || diaSemana == '3')
//        {
//            Console.WriteLine($"O preco do ingresso 3d, estudante e terca feira sera de {(meia * terca) + meia + 8}");
//        }
//    }
//}
//if (idade <0  || idade > 120)
//{
//    Console.WriteLine("Idade invalida.");
//} else if (diaSemana <1 || diaSemana > 7)
//{
//    Console.WriteLine("Dia invalido");
//}
//else
//{

//}

//////////////////////////////////////////////
/////Console.WriteLine("Insira sua idade:");
//int idade = int.Parse(Console.ReadLine());
//Console.WriteLine("Voce e estudante?");
//char estudante = char.Parse(Console.ReadLine());
//Console.WriteLine("Qual e o dia da semana?");
//int diaSemana = int.Parse(Console.ReadLine());
//Console.WriteLine("Aa secao e em 3d?");
//char sesao = char.Parse(Console.ReadLine());
//int ingresso = 40;
//int meia = ingresso / 2;
//double terca = 0.20;

Console.Write("Insira sua idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade < 0 || idade > 120)
{
    Console.WriteLine("Idade inválida.");
    return;
}

Console.Write("Qual é o dia da semana? (1-7): ");
int diaSemana = int.Parse(Console.ReadLine());
if (diaSemana < 1 || diaSemana > 7)
{
    Console.WriteLine("Dia inválido.");
    return;
}

Console.Write("Você é estudante? (s/n): ");
char estudante = char.Parse(Console.ReadLine().ToLower());

Console.Write("A sessão é em 3D? (s/n): ");
char sessao3D = char.Parse(Console.ReadLine().ToLower());

double precoFinal = 40.0;

if (idade < 12 || idade >= 60 || estudante == 's')
{
    precoFinal = precoFinal / 2;
}

if (diaSemana == 3)
{
    precoFinal = precoFinal + (precoFinal * 0.20);
}

if (sessao3D == 's')
{
    precoFinal = precoFinal + 8;
}

Console.WriteLine($"\nO preço final do seu ingresso será de: R$ {precoFinal:F2}");