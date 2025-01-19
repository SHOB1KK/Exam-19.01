System.Console.WriteLine("Создаем товар...");
System.Console.Write("Название: ");
string name = Console.ReadLine();
System.Console.Write("Цена: ");
int price = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество: ");
int count = Convert.ToInt32(Console.ReadLine());
Product Apple = new Product(name,price,count);
System.Console.Write("Сколько добавить?:");
int a = Convert.ToInt32(Console.ReadLine());
Apple.Add(a);
System.Console.Write("На складе осталось: ");
Apple.ShowInfo();
System.Console.Write("Сколько взять?:");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("На складе осталось: ");
Apple.Sell(b);
Apple.ShowInfo();
class Product
{
    public string Name;
    public int Price;
    public int Count;

    public Product(string name,int price,int count){
     Name=name;
     Price=price;
     Count=count;
    }
    public void Sell(int amount){
        Count-=amount;
    }
    public void Add(int amount){
        Count+=amount;
    }
    public void ShowInfo(){
        System.Console.WriteLine(Count);
    }
}