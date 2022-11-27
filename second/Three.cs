namespace WASP_tasks.second;

public class Three
{
    public static void Main_(string[] args)
    {
        short a = Convert.ToInt16(Console.ReadLine());
        short b = Convert.ToInt16(Console.ReadLine());
        short c = Convert.ToInt16(Console.ReadLine());
        short d = Convert.ToInt16(Console.ReadLine());
        long r = 0;
                
        r |= (ushort)d;
        for (int i = 1; i <= 16; i++)
            r <<= 1;

        r |= (ushort)c;
        for (int i = 1; i <= 16; i++)
            r <<= 1;

        r |= (ushort)b;
        for (int i = 1; i <= 16; i++)
            r <<= 1;

        r |= (ushort)a;
            
        // Console.WriteLine(Convert.ToString(r, 2));
        Console.WriteLine(r);
    }
}