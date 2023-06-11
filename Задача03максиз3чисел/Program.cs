Console.Clear();
Console.WriteLine("Введите три числа:");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int numD = int.Parse(Console.ReadLine());
if (numA>numB&numA>numD)
{
    Console.WriteLine ($"Max={numA}");
}
else if (numB>numA&numB>numD)
{
    Console.WriteLine($"Max={numB}");
}
else if (numD>numA&numD>numB)
{
Console.WriteLine($"Max={numD}");
}