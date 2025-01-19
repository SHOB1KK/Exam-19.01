Piggy pig = new Piggy();
System.Console.WriteLine("Первое число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Второе число: ");
int b = int.Parse(Console.ReadLine());
pig.Add(a,b);
pig.Substract(a,b);
pig.Multiply(a,b);
class Piggy {
    public int a;
    public int b;
    public string Add(int a, int b){
        System.Console.WriteLine($"Сумма двух чисел: {a+b}");
    }
    public string Substract(int a, int b){
        System.Console.WriteLine($"Вычесть двух чисел: {a-b}");
    }
    public string Multiply(int a, int b){
        System.Console.WriteLine($"Умножение двух чисел: {a*b}");
    }
}