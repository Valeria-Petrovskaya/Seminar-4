Console.Clear();
int [] newArray = new int [8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Введите число: ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"{string.Join(", ", newArray)}");