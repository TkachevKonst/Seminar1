Console.Clear();
Console.Write("Введите число:");
int numA = int.Parse(Console.ReadLine());
int numB = numA%2;
if (numB == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}