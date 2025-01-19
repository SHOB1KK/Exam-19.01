Piggy pig = new Piggy();
System.Console.WriteLine("Деньги в кошельке: ");
int money = int.Parse(Console.ReadLine());
System.Console.WriteLine("Достаем деньги: ");
int amount = int.Parse(Console.ReadLine());
pig.Add(money);
pig.Take(amount);
pig.ShowMoney();
class Piggy {
    public int money;
    public void Add(int amount){
        money += amount;
        System.Console.WriteLine($"В копилке: {money}");
        
    }
    public void Take(int amount){
        money = money - amount;
        System.Console.WriteLine($"Достаем {amount}");
    }

    public void ShowMoney(){
        System.Console.WriteLine($"Осталось в копилке: {money}");
    }
}