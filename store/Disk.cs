namespace WASP_tasks.store;

public class Disk : IStoreItem
{
    private string _name;
    private string _genre;
    private int _burnCount;
    private IStoreItem _storeItemImplementation;

    public string Name { get => _name; set => _name = value; }
    public string Genre { get => _genre; set => _genre = value; }
    public int BurnCount { get => _burnCount; set => _burnCount = value; }
    public double Price 
    { 
        get => _storeItemImplementation.Price; 
        set => _storeItemImplementation.Price = value;
    }
    
    public virtual int DiskSize { get; set; }
    
    public Disk(string name, string genre)
    {
        _name = name;
        _genre = genre;
        _burnCount = 0;
    }

    public virtual void Burn(params string[] values)
    {
        
    }
    
    public void DiscountPrice(int percent)
    {
        this.Price *= (double)(100 - percent) / 100;
    }
}

public class Audio : Disk
{
    private string _artist;
    private string _recordingStudio;
    private int _songsNumber;

    public string Artist { get => _artist; set => _artist = value; }
    public string RecordingStudio
    {
        get => _recordingStudio; 
        set => _recordingStudio = value;
    }
    public int SongsNumber
    {
        get => _songsNumber; 
        set => _songsNumber = value;
    }
    
    public override int DiskSize { get => this.SongsNumber * 8; }

    public Audio(string artist, string recordingStudio, int songsNumber, 
        string name, string genre) : base(name, genre)
    {
        _artist = artist;
        _recordingStudio = recordingStudio;
        _songsNumber = songsNumber;
    }

    public override void Burn(params string[] values)
    {
        this.Name = values[0];
        this.Genre = values[1];
        this.Artist = values[2];
        this.RecordingStudio = values[3];
        this.SongsNumber = Convert.ToInt32(values[4]);
        this.BurnCount++;
    }

    public override string ToString()
    {
        return $"{this.Name}, {this.Genre}, {this.Artist}, " +
               $"{this.RecordingStudio}, {this.SongsNumber}, {this.BurnCount}";
    }
}

public class DVD : Disk
{
    private string _producer;
    private string _filmCompany;
    private int _minutesCount;

    public string Producer { get => _producer; set => _producer = value; }
    public string FilmCompany
    {
        get => _filmCompany; 
        set => _filmCompany = value;
    }
    public int MinutesCount
    {
        get => _minutesCount;
        set => _minutesCount = value;
    }
    
    public override int DiskSize { get => (this.MinutesCount / 64) * 2; }
    
    public DVD(string producer, string filmCompany, int minutesCount, 
        string name, string genre) : base(name, genre)
    {
        _producer = producer;
        _filmCompany = filmCompany;
        _minutesCount = minutesCount;
    }
    
    public override void Burn(params string[] values)
    {
        this.Name = values[0];
        this.Genre = values[1];
        this.Producer = values[2];
        this.FilmCompany = values[3];
        this.MinutesCount = Convert.ToInt32(values[4]);
        this.BurnCount++;
    }
    
    public override string ToString()
    {
        return $"{this.Name}, {this.Genre}, {this.Producer}, " +
               $"{this.FilmCompany}, {this.MinutesCount}, {this.BurnCount}";
    }
}