using System.Runtime.InteropServices;

namespace WASP_tasks.store;

public class Program
{
    public static void Main(string[] args)
    {
        Store store = new Store("DrHead", "New Arbat st., 15");
        
        store.Audios = store + new Audio("Ludovico Einaudi", "VEVO", 
            12, "Underwater LP","Classical");
        store.Audios = store + new Audio("Max Richter", "Deutsche Grammophon", 
            15, "Infra LP","Modern Classical");
        store.Audios = store + new Audio("Philip Glass", "Sony Music", 
            7, "Solo Piano LP","Contemporary");
        
        store.DVDs = store + new DVD("Steven Spielberg", "Amblin Entertainment", 
            197, "Schindler's List","Historical drama");
        store.DVDs = store + new DVD("Morten Tyldum", "Black Bear Pictures", 
            114, "The Imitation Game","Drama");
        
        Console.WriteLine(store.ToString());
        
        store.DVDs[1].Burn("Inception", "Sci-fi thriller", 
            "Christopher Nolan", "Legendary Pictures", "148");

        foreach (var audio in store.Audios)
        {
            Console.WriteLine($"{audio.Name} → {audio.DiskSize}");
        }
        foreach (var dvd in store.DVDs)
        {
            Console.WriteLine($"{dvd.Name} → {dvd.DiskSize}");
        }
    }
}