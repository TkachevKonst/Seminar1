Console.Clear();
Console.Write("Введите число:");
int numA = int.Parse(Console.ReadLine());
for (int i = 1; i <=numA ; i++)
{
    if (i%2==0)
    {
        Console.Write(i + " ");
    }
}