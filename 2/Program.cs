Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
int m = n;
while (m > 0)
{
    int q = m % 10;
    i = i + q;
    m = (m - q) / 10;
}

Console.WriteLine($"Сумма цифр: {i}");