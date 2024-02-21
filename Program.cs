Song song1 = new Song();
song1.name = "Love Hurts";
song1.singer = "Nazareth";
song1.duration = 273;
song1.available = true;

Song song2 = new Song();
song2.name = "Cruel Summer";
song2.singer = "Taylor Swift";
song2.duration = 337;
song2.available = false;

song1.ExibirFichaTecnica();
Console.WriteLine("----------------------");
song2.ExibirFichaTecnica();