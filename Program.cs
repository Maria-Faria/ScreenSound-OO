Song song1 = new Song();
song1.Name = "Love Hurts";
song1.Singer = "Nazareth";
song1.Duration = 273;
song1.Available = true;
Console.WriteLine(song1.Description);

Song song2 = new Song();
song2.Name = "Cruel Summer";
song2.Singer = "Taylor Swift";
song2.Duration = 337;
song2.Available = false;

song1.ExibirFichaTecnica();
Console.WriteLine("----------------------");
song2.ExibirFichaTecnica();
