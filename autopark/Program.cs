namespace WASP_tasks.autopark;

public class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Moscvich", 50, 1970);
        PassengerCar car2 = new PassengerCar("Pobeda", 50, 1950, 5);
        PassengerCar car3 = new PassengerCar("Volga", 75, 1962, 5);
        car3.AddReplacedPart("tires", 1970);
        car3.AddReplacedPart("headlights", 1972);
        car3.GetReplacementYear("headlights");
        car3.PrintRepairBook();
        Truck car4 = new Truck("CamAZ", 210, 1980, 5000, "Ivanov_Ivan");
        Truck car5 = new Truck("BelAZ", 360, 1965, 12000, "Pavlov_Pavel");
        car5.ChangeDriver("Petrov_Petr");
        car4.AddCargo("cement", 3000);
        car4.RemoveCargo("cement");
        car4.AddCargo("marble", 2000);
        car5.AddCargo("stone", 5000);
        car5.AddCargo("gravel", 6000);
        car4.PrintCurrentCargo();
        car5.PrintCurrentCargo();
        Autopark autopark = new Autopark("Yamdex", new List<Car>()
        {
            car1, car2, car3, car4, car5
        });
        Console.WriteLine(autopark.ToString());
    }
}