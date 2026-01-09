//who s song producer

using System;
using System.Collections.Generic;

class Song
{
    List<string> Lyrics;

    public Song(List<string> lyrics)
    {
        Lyrics = lyrics;
    }

    public void SingMeASong()
    {
        foreach (var line in Lyrics)
        {
            Console.WriteLine(line);
        }
    }
}

class Exercise11
{
    public static void Songprod()
    {
        var stairway = new Song(new List<string>{
            "There’s a lady who's sure",
            "all that glitters is gold",
            "and she’s buying a stairway to heaven"
        });

        stairway.SingMeASong();
    }
}