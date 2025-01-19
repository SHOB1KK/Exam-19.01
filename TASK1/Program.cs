Console.WriteLine("Введите первое число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число:");
        int num3 = int.Parse(Console.ReadLine());

        int sum = num1 + num2 + num3;

        int max = Math.Max(num1, Math.Max(num2, num3));

        int min = Math.Min(num1, Math.Min(num2, num3));

        Console.WriteLine($"Сумма чисел: {sum}");
        Console.WriteLine($"Самое большое число: {max}");
        Console.WriteLine($"Самое маленькое число: {min}");
