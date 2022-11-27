namespace WASP_tasks.first;

public class Two
{
    public static void Main_(string[] args)
    {
        int i, n = Convert.ToInt32(Console.ReadLine());

        for (i = n; i > 0; i--)
        {
            int j = 0, k = i;
                
            while (k < n && j < n)
            {
                Console.Write(k);
                k++;
                j++;
            }
                
            while (k > 0 && j < n)
            {
                Console.Write(k);
                k--;
                j++;
            }
                
            Console.WriteLine();
        }
    }
}