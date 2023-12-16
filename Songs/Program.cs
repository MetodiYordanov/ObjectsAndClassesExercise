using Songs;

int numberOfSongs = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();

for (int i = 0; i < numberOfSongs; i++)
{
    string[] songComponents = Console.ReadLine()
                              .Split("_");

    string songTypeList = songComponents[0];
    string songName = songComponents[1];
    string songTime = songComponents[2];

    Song currentSong = new Song
    {
        TypeList = songTypeList,
        Name = songName,
        Time = songTime
    };

    songs.Add(currentSong);
}

string typeCommand =  Console.ReadLine();

if (typeCommand == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (Song song in songs.Where(s => s.TypeList == typeCommand))
    {
        Console.WriteLine(song.Name);
    }
}