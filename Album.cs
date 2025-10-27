using System;
public class Album
{
    private string albumName;
    private string artist;
    private int numTracks;

    public void Start()
    {
        Console.Write("Ange albumnamn: ");
        albumName = Console.ReadLine();
        Console.Write("Ange artist: ");
        artist = Console.ReadLine();
        Console.Write("Antal låtar: ");
        numTracks = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Album: {albumName}, Artist: {artist}, Antal låtar: {numTracks}");
    }
}
