public class Vehicle
{
    public string Name;
    int NumberOfPassengers;
    string Color;
    bool Engine;
    int MilesTraveled;

    public Vehicle(string name, int numberOfPassengers, string color, bool engine)
    {
        Name = name;
        NumberOfPassengers = numberOfPassengers;
        Color = color;
        Engine = engine;
        MilesTraveled = 0;
    }
    public Vehicle(string name, string color)
    {
        Name = name;
        NumberOfPassengers = 4;
        Color = color;
        Engine = true;
        MilesTraveled = 0;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Info about this Vehicle---");
        Console.WriteLine("Name-" + Name);
        Console.WriteLine("Number of Passengers-" + NumberOfPassengers);
        Console.WriteLine("Color-" + Color);
        Console.WriteLine("Engine-" + Engine);
        Console.WriteLine("Miles Traveled-" + MilesTraveled);
    }
    public void Miles(int miles)
    {
        MilesTraveled += miles;
        Console.WriteLine("The Mileage of this vehicle is -" + MilesTraveled);
    }
}

