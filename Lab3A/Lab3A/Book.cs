using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /*
    Class:  Book.cs
    Author: Hamza Saleh,000887384
    Date:   October 31,2023 
    this is my own work I have not shared this code with anyone else and I have not copied any code from anyone.

    This is the book class that inherits from media
     */
    public class Book: Media, IEncryptable
    {
        //properties
        public string Author { get; set; }
        public string Summary { get; set; }


        //the constructor
        public Book( string author, string summary, string title, int year) : base(title, year)
        {
            Author = author;
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
