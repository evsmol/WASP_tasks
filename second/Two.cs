namespace WASP_tasks.second;

public class Two
{
    public static string to_bin(int n)
    {
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

        bin_n = bin_n.TrimStart('0');

        return bin_n;
    }
    
    public static void Main_(string[] args)
    {
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        string bin_m = to_bin(m);
        string bin_n = to_bin(n);

        // сложение
        int perenos;
        while (n != 0)
        {
            perenos = (m & n);
            m ^= n;
            n = perenos << 1;
        }

        string bin_r = to_bin(m);
        int len_r = bin_r.Length;
        int len_m = bin_m.Length;
        int len_n = bin_n.Length;

        Console.WriteLine($"{new String('0', len_r - len_m)}{bin_m}\n" +
                          $"{new String('0', len_r - len_n)}{bin_n}\n" +
                          $"{new String('-', len_r)}\n" +
                          $"{bin_r}");
    }
}