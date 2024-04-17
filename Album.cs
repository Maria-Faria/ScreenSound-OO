class Album 
{
    private List<Song> songs = new List<Song>();
    public string Name { get; set; }
    public int Duration => songs.Sum(song => song.Duration);
    
    public void addSong(Song song)
    {
        songs.Add(song);
    }

    public void showAlbumSongs()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (var song in songs )
        {
            Console.WriteLine($"Música: {song.Name}");
        }

        Console.WriteLine($"\nPara ouvir esse álbum inteiro, você precisa de {Duration} segundos!");
    }
}