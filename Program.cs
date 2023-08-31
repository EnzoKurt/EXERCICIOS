// See https://aka.ms/new-console-template for more information
double sm,qtd,kw;
Console.WriteLine("Digite o salário mínimo: ");
sm= double.Parse(Console.Readline());
Console.WriteLine("Digite a quantidade gasta de kw: ");
qtd= double.Parse(Console.Readline());
kw= (sm/7)/100;
Console.WriteLine("O valor em reais, de cada kw é {0} ", kw);
