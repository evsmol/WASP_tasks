namespace WASP_tasks.autopark;

public class Car
{
    private string _brand;
    private int _horsepower;
    private int _yearOfProduction;

    public Car(string brand, int horsepower, int yearOfProduction)
    {
        _brand = brand;
        _horsepower = horsepower;
        _yearOfProduction = yearOfProduction;
    }

    public string Brand { get => _brand; set => _brand = value; }
    public int Horsepower { get => _horsepower; set => _horsepower = value; }
    public int YearOfProduction { get => _yearOfProduction; set => 
    _yearOfProduction = value; }

    public override string ToString()
    {
        return $"brand: {_brand}; " +
               $"horsepower: {_horsepower}; " +
               $"year_of_production: {_yearOfProduction}";
    }
}

public class PassengerCar : Car
{
    private int _numberOfPassengers;
    private Dictionary<string, int>
        _repairBook = new Dictionary<string, int>();
    
    public int NumberOfPassengers { get => _numberOfPassengers; 
                                    set => _numberOfPassengers = value; }

    public PassengerCar(string brand, int horsepower, int yearOfProduction, 
        int numberOfPassengers) : base(brand, horsepower, yearOfProduction)
    {
        _numberOfPassengers = numberOfPassengers;
    }

    public void AddReplacedPart(string sparePart, int replacementYear)
    {
        _repairBook.Add(sparePart, replacementYear);
    }

    public int GetReplacementYear(string sparePart)
    {
        return _repairBook[sparePart];
    }

    public void PrintRepairBook()
    {
        Console.WriteLine($"spare_part---replacementYear");
        foreach(var sparePart in _repairBook)
        {
            Console.WriteLine($"{sparePart.Key}---{sparePart.Value}");
        }
    }

    public override string ToString()
    {
        return $"brand: {this.Brand}; " +
               $"horsepower: {this.Horsepower}; " +
               $"year_of_production: {this.YearOfProduction}; " +
               $"number_of_passengers: {_numberOfPassengers}";
    }
}

public class Truck : Car
{
    private int _loadCapacity;
    private string _nameOfDriver;
    private Dictionary<string, int>
        _currentCargo = new Dictionary<string, int>();
    
    public int LoadCapacity { get => _loadCapacity; 
        set => _loadCapacity = value; }
    public string NameOfDriver { get => _nameOfDriver; 
        set => _nameOfDriver = value; }
    
    public Truck(string brand, int horsepower, 
        int yearOfProduction, int loadCapacity, 
        string nameOfDriver) : base(brand, horsepower, yearOfProduction)
    {
        _loadCapacity = loadCapacity;
        _nameOfDriver = nameOfDriver;
    }

    public void ChangeDriver(string nameOfDriver)
    {
        _nameOfDriver = nameOfDriver;
    }

    public void AddCargo(string productName, int weight)
    {
        _currentCargo.Add(productName, weight);
    }

    public void RemoveCargo(string productName)
    {
        _currentCargo.Remove(productName);
    }

    public void PrintCurrentCargo()
    {
        Console.WriteLine($"product_name---weight");
        foreach(var product in _currentCargo)
        {
            Console.WriteLine($"{product.Key}---{product.Value}");
        }
    }

    public override string ToString()
    {
        return $"brand: {this.Brand}; " +
               $"horsepower: {this.Horsepower}; " +
               $"year_of_production: {this.YearOfProduction}; " +
               $"load_capacity: {_loadCapacity}; " +
               $"name_of_driver: {_nameOfDriver}";
    }
}