class Album 
{
    private List<Song> songs = new List<Song>;
    public string Name { get; set; }
    public int Duration { get; set; }
    
    public void addSong(Song song)
    {
        songs.Add(song);
    }
}