namespace WASP_tasks.store;

public class Store
{
    private string _storeName;
    private string _address;
    private List<Audio> _audios = new List<Audio>();
    private List<DVD> _dvds = new List<DVD>();
    
    public string StoreName { get => _storeName; set => _storeName = value; }
    public string Address { get => _address; set => _address = value; }
    public List<Audio> Audios { get => _audios; set => _audios = value; }
    public List<DVD> DVDs { get => _dvds; set => _dvds = value; }

    public Store(string storeName, string address)
    {
        _storeName = storeName;
        _address = address;
        _audios = new List<Audio>();
        _dvds = new List<DVD>();
    }

    public static List<Audio> operator +(Store store, Audio audio)
    {
        store.Audios.Add(audio);
        return store.Audios;
    }
    
    public static List<Audio> operator -(Store store, Audio audio)
    {
        store.Audios.Remove(audio);
        return store.Audios;
    }
    
    public static List<DVD> operator +(Store store, DVD dvd)
    {
        store.DVDs.Add(dvd);
        return store.DVDs;
    }
    
    public static List<DVD> operator -(Store store, DVD dvd)
    {
        store.DVDs.Remove(dvd);
        return store.DVDs;
    }

    public override string ToString()
    {
        string output = "";

        output += $"store_name: {_storeName}";
        output += $"\naddress: {_address}";
        output += $"\naudio:";
        foreach (var audio in _audios)
        {
            output += $"\n{audio.ToString()}";
        }
        output += $"\ndvds:";
        foreach (var dvd in _dvds)
        {
            output += $"\n{dvd.ToString()}";
        }

        return output;
    }
}