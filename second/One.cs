namespace WASP_tasks.second;

public class One
{
    public static void Main_(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string bin_n_rev = "";
        string bin_n = "";

        bin_n_rev += n & 1;
        for (int i = 1; i <= 32; i++)
        {
            n >>= 1;
            bin_n_rev += n & 1;
        }

        for (int i = bin_n_rev.Length - 1; i >= 0; i--)
            bin_n += bin_n_rev[i];

        Console.WriteLine($"{n} -> {bin_n.TrimStart('0')}");
    }
}