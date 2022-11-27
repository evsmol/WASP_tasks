namespace WASP_tasks.first;

public class One
{
    public static void Main_(string[] args)
    {
        int a, b, c, d;
        
        for (a = 9; a != 1; a--)
            for (b = a - 1; b >= 0; b--)
                for (c = b - 1; c >= 0; c--)
                    for (d = c - 1; d >= 0; d--)
                        Console.WriteLine($"{a}{b}{c}{d}");
    }
}
