int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
void Setnumbers(int num)
{
    if (num % 2 == 0)
    {
        System.Console.WriteLine($"Число {num} являеться четным");
    }
    else
    {
        System.Console.WriteLine($"Число {num} являеться нечетным");
    }

    string Max(int a, int b)
    {
        if (a > b)
        {
            return $"Максимальное число {a}";
        }
        else
        {
            return $"Максимальное число {b}";
        }
    }
}
System.Console.WriteLine($"Сумма чисел: {a + b}");
System.Console.WriteLine("Результат: ");
Setnumbers(a);
Setnumbers(b);