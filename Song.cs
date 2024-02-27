class Song
{
    public string Name {get; set;}
    public string Singer { get; set;}
    public int Duration { get; set;}
    public bool Available { get; set; }
    public string Description =>
        $"A música {Name} pertence à banda {Singer}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Singer}");
        Console.WriteLine($"Duração: {Duration}");
    
        if(Available)
        {
            Console.WriteLine("Disponível no plano.");
        
        }else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    
}