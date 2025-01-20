using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    ///  Class:  Movie.cs
    ///Author: Hamza Saleh,000887384
    ///Date:   October 31,2023
    /// this is the movie class that inherits from media
    /// this is my own work I have not shared this code with anyone else and I have not copied any code from anyone.
    /// </summary>
    public class Movie: Media, IEncryptable
    {
        //properties
        public string Director { get; set; }
        public string Summary { get; set; }

        //the constructor
        public Movie(string director, string summary, string title, int year) : base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        //the encrypt and decrypt methods
        public string Encrypt(string input)
        {
            StringBuilder x = new StringBuilder();

            foreach (char c in input)
            {
                if ((c >= 'a' && c <= 'm') || (c >= 'A' && c <= 'M'))
                {
                    x.Append((char)(c + 13));
                }
                else if ((c >= 'n' && c <= 'z') || (c >= 'N' && c <= 'Z'))
                {
                    x.Append((char)(c - 13));
                }
                else
                {
                    x.Append(c);
                }
            }

            return x.ToString();

        }
        public string Decrypt(string input)
        {
            StringBuilder x = new StringBuilder();

            foreach (char c in input)
            {
                if ((c >= 'a' && c <= 'm') || (c >= 'A' && c <= 'M'))
                {
                    x.Append((char)(c + 13));
                }
                else if ((c >= 'n' && c <= 'z') || (c >= 'N' && c <= 'Z'))
                {
                    x.Append((char)(c - 13));
                }
                else
                {
                    x.Append(c);
                }
            }

            return x.ToString();

        }
    }
}
