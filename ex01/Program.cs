// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite um numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("digite um numero");
int numero2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("======================");
Console.WriteLine("=== soma de numero ===");
Console.WriteLine("======================");

Console.WriteLine($" + : {numero1 + numero2}");
Console.WriteLine($" - : {numero1 - numero2}");
Console.WriteLine($" * : {numero1 * numero2}");

if (numero2 != 0);
{
    Console.WriteLine("/:" + numero1 / numero2));
}
else
{ Console.WriteLine("/: + Divisão por 0 não é permitida");
}
Console.WriteLine("os numero são iguais? " + (numero1 == numero2));
Console.WriteLine("os numero maior numero 2? " + (numero1 > numero2));
Console.WriteLine("os numero menor numero 2? " + (numero1 < numero2));
Console.WriteLine("os numero maior  igual numero 2? " + (numero1 >= numero2));
Console.WriteLine("os numero menor  igual numero 2? " + (numero1 <= numero2));



