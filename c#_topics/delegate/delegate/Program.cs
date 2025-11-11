
public delegate void ActionDelegate(int number);

public class Demo
{
    public static void CalculateSquare(int number)
    {
        Console.WriteLine(number * number);
    }
    
    public static void Main()
    {
        ActionDelegate action = CalculateSquare;
        action(5);
    }
}