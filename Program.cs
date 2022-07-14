
public class FileIO 
{ 
    string welcome;
    public FileIO()
    {
        Console.WriteLine("Welcome to Address Book");
    }
    public FileIO(string welcome)
    {
        this.welcome = welcome;
    }
    public void show()
    {
        Console.WriteLine("Welcome to Address Book");
    }
    public static void show1()
    { Console.WriteLine("Welcome to Address Book"); }
    public static void show1(string well)
    {
        Console.WriteLine(well);
    }

    public static void Main(string[] args)
    {
        FileIO display = new FileIO();
        FileIO display1 = new FileIO("Welcome to Address Book");
        show1();
        show1("Welcome to Address Book");
        display.show();
        Console.ReadLine();
    }
    
}