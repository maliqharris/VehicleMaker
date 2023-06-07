Vehicle Bike = new Vehicle("Bike", 1, "Red", false);
Vehicle NissanAltima = new Vehicle("Nissan Altima", 5, "Blue", true);
Vehicle Lexuse330 = new Vehicle("Lexus E330", "White");
Vehicle BMW325 = new Vehicle("BMW 325i", "Yellow");



List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(Bike);
vehicles.Add(NissanAltima);
vehicles.Add(Lexuse330);
vehicles.Add(BMW325);

foreach (Vehicle vehicle in vehicles)
{
    vehicle.ShowInfo();
}
Bike.Miles(100);