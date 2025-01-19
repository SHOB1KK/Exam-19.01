System.Console.WriteLine("Создаем кошку...");
System.Console.Write("Имя: ");
string Name = Console.ReadLine();
System.Console.Write("Возраст: ");
int Age = int.Parse(Console.ReadLine());

Cat cat_1 = new Cat(Name, Age);
cat_1.Say();
cat_1.ShowInfo();

class Cat
{
    public string? Name;
    public int Age;

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Say()
    {
        System.Console.WriteLine($"Кошка говорит мяу!");
        System.Console.WriteLine("Информатция о кошке:");
    }
    public void ShowInfo()
    {
        System.Console.WriteLine($"Кошка: {Name} Возраст: {Age}");
    }
}