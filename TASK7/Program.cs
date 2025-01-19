Book book = new Book("NAgzay", "Huvaido", 2025);
int year = Convert.ToInt32(Console.ReadLine());
book.Inf();
bool bln = book.Isnew(year);
if(bln){
    System.Console.WriteLine("да");
}
else{
    System.Console.WriteLine("нет");
}
class Book{
    public string Title;
    public string Authot;
    public int Year;

    public Book(string title, string authot, int year){
        Title = title;
        Authot = authot;
        Year = year;
    }

    public void Inf(){
        System.Console.WriteLine($"Book = {Title}, Authour = {Authot}, Year = {Year}");
    }

    public bool Isnew(int year){
        if(year > 1800){
            return true;
        }
        else{
            return false;
        }
    }
}

