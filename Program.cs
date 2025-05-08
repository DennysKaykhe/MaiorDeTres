int n1, n2, n3;

Console.Clear();

Console.WriteLine("--- EU ADVINHAREI O MAIOR NÚMERO QUE VOCÊ ESCREVER! ---\n");

Console.Write("Segundo número: ");
n1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Segundo número: ");
n2 = Convert.ToInt16(Console.ReadLine());

Console.Write("Terceiro número: ");
n3 = Convert.ToInt16(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkGreen;

int numerodescoberto;

if (n1 > n3)
{
    if (n1 > n3)
    {
        numerodescoberto = n1;
    }
    else
    {
        numerodescoberto = n3;
    }
}
else
{
    if (n2 > n3)
    {
        numerodescoberto = n2;
    }
    else
    {
        numerodescoberto = n3;
    }
    
}

Console.WriteLine($"\nO MAIOR NÚMERO ENTRE OS TRÊS É O {numerodescoberto}, é esse não é? Otário!");

Console.WriteLine(@"
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜⬜⬜
⬜⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜⬜
⬜⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜⬜
⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜
⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜
⬜⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬜
⬜⬛⬜⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬜
⬜⬛⬜⬜⬜⬛⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬛⬜⬜⬜⬛⬜
⬜⬛⬜⬜⬛⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬛⬜⬜⬛⬛⬛⬛⬛⬜⬜⬛⬜
⬜⬛⬜⬜⬛⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬛⬜⬜⬛⬛⬛⬛⬛⬜⬜⬛⬜
⬜⬜⬛⬜⬛⬛⬛⬛⬛⬛⬛⬛⬜⬜⬛⬜⬜⬛⬛⬛⬛⬛⬛⬛⬛⬜⬛⬜⬜
⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜⬜⬛⬜⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜
⬜⬜⬜⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬛⬛⬛⬜⬜⬜⬛⬛⬜⬜⬜⬜⬛⬜⬜⬜
⬜⬜⬜⬛⬜⬜⬛⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬛⬜⬜⬛⬜⬜⬜
⬜⬜⬛⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬛⬜⬜
⬜⬜⬛⬜⬜⬛⬛⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬜⬛⬜⬜
⬜⬜⬛⬜⬜⬜⬛⬜⬛⬜⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬜⬛⬛⬜⬜⬜⬛⬜⬜
⬜⬜⬜⬛⬜⬜⬜⬛⬛⬜⬜⬛⬜⬜⬛⬜⬜⬛⬜⬛⬜⬛⬜⬜⬜⬛⬜⬜⬜
⬜⬜⬜⬛⬜⬜⬜⬜⬛⬛⬜⬛⬜⬜⬛⬜⬜⬛⬜⬜⬛⬜⬜⬜⬜⬛⬜⬜⬜
⬜⬜⬜⬜⬛⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜");

Console.ResetColor();