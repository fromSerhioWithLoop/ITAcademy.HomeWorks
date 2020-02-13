using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace less_14_2
{
    
    public class Song
    {

        public string Name { get; set; } 
        public string Lenght { get; set; }
        public string Album { get; set; }
        public string Year { get; set; } 
        public string Autor { get; set; } 

        
        public object GetSongData(dynamic x)
        {
            try { Name = x.name; } catch { Name = "Unknown"; }
            try { Lenght = x.lenght.ToString(); } catch { Lenght = "Unknown"; }
            try { Album = x.album; } catch { Album = "Unknown"; }
            try { Year = x.year.ToString(); } catch { Year = "Unknown"; }
            try { Autor = x.autor; } catch {Autor = "Unknown"; }

            return $"   Song:{Name},\t\tLenght(min):{Lenght},\tAlbum:{Album},\tYear:{Year},\tAutor:{Autor}";
        }
    }
}
