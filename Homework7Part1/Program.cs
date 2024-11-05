using Homework7Part1;

internal class Program
{
    private static void Main(string[] args)
    {
        odometer trip1 = new odometer();
        trip1.add(50, 10);
        Console.WriteLine(trip1.toString());
        Console.WriteLine("Fuel used for trip1 is " + trip1.MPG());

        odometer trip2 = new odometer(100,20);
        Console.WriteLine("Fuel used for trip2 is " + trip2.MPG());
        trip1.reset();
        Console.WriteLine(trip1.toString());

    }
}