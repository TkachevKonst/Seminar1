Console.Clear();
Console.WriteLine("Введите два числа:");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
if (numA>numB)
{
    Console.WriteLine($"Max={numA}, Min={numB}");
}
else
{
    Console.WriteLine($"Max={numB}, Min={numA}");
}
