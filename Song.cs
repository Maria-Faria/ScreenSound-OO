class Song
{
    public string name;
    public string singer;
    public int duration;
    public bool available;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Artista: {singer}");
        Console.WriteLine($"Duração: {duration}");
    
        if(available)
        {
            Console.WriteLine("Disponível no plano.");
        
        }else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}