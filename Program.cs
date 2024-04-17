Album imagineDragons = new Album();

imagineDragons.Name = "Origins";

Song song1 = new Song();
song1.Name = "Natural";
song1.Duration = 189;

Song song2 = new Song();
song2.Name = "Machine";
song2.Duration = 181;

imagineDragons.addSong(song1);
imagineDragons.addSong(song2);

imagineDragons.showAlbumSongs();