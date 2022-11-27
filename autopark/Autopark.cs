namespace WASP_tasks.autopark;

public class Autopark
{
    private string _nameOfAutopark;
    private List<Car> _cars = new List<Car>();

    public string NameOfAutopark { get => _nameOfAutopark; 
        set => _nameOfAutopark = value; }
    
    public Autopark(string nameOfAutopark, List<Car> cars)
    {
        _nameOfAutopark = nameOfAutopark;
        _cars = cars;
    }
    
    public override string ToString()
    {
        string output = "";

        output += $"name_of_autopark: {_nameOfAutopark}";
        foreach (var car in _cars)
        {
            output += $"\n{car.ToString()}";
        }

        return output;
    }
}