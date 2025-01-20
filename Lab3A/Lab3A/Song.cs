using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /*
    Class:  Song.cs
    Author: Hamza Saleh,000887384
    Date:   October 31,2023
    this is my own work I have not shared this code with anyone else and I have not copied any code from anyone.

    This is the song class that inherits from media
     */
    public class Song:Media
    {
        //properties
        public string Artist { get; set; }
        public string Album { get; set; }


        //the constructor
        public Song(string artist, string album, string title, int year) : base(title, year)
        {
            Artist =artist;
            Album = album;
        }
    }
}
