System.Console.WriteLine("Введите длительность массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
System.Console.WriteLine("Введите числа: ");
for (int i=0;i<arr.Length;i++){
    arr[i] = int.Parse(Console.ReadLine());
}
int pos = 0;
int neg = 0;
int sum = 0;
for (int i=0;i<arr.Length;i++){
    if (arr[i]%2==0){
        pos++;
    }
    else {
        neg++;
    }
    if (arr[i]>0){
        sum+=arr[i];
    }
}
System.Console.WriteLine($"Количество четных чисел: {pos}");
System.Console.WriteLine($"Количество нечетных чисел: {neg}");
System.Console.WriteLine($"Сумма положительных чисел: {sum}");