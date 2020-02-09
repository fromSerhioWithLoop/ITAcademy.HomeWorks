using System;

namespace less_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic EverDream = new
            {
                name = "Ever Dream",
                album="EndofEra",
                autor="Nigtwish  "
            };
            object NoMatter = new
            {
                name = "NothingMatter",
                lenght = 3.25,
                album = "Metalica",
                year = 1990,
            };
            var Dangerous = new
            {
                name = "Dangerous",
                lenght = 5.01,
                album = "Hydra",
                year = 2013,
                autor = "Within Temptation"
            };

            Song song = new Song();
            Console.WriteLine(song.GetSongData(EverDream));
            Console.WriteLine(song.GetSongData(NoMatter));
            Console.WriteLine(song.GetSongData(Dangerous));
            Console.ReadKey();
        }
    }
}
