Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int resultNumber = 1;

while (B > 0)
{
    resultNumber = resultNumber * A;
    B = B - 1;
}

Console.WriteLine($"Result: {resultNumber}");