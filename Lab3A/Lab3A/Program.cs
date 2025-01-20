using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /*
  Class:  program.cs
  Author: Hamza Saleh,000887384
  Date:   October 31,2023
  this is my own work I have not shared this code with anyone else and I have not copied any code from anyone.

  This is the main class that reads the data from the file and displays the menu and calls the functions
   */
    public class Program
    {


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow; 
            Console.Clear(); 
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.Title = "Media Library"; 

            //create an object of the program class
            Program x = new Program();

            //call the read data function
            x.ReadData();

        }

        //create an array of media and set the counter to 0
        Media[] media = new Media[100];
        int counter = 0;

     

       
       /// <summary>
       /// read data function to read the data from the file
       /// </summary>
        public void ReadData()
        {

            try {


                using (FileStream fs = new FileStream("Data.txt", FileMode.Open, FileAccess.Read))
                using (StreamReader read = new StreamReader(fs))
                {
                    
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        //if the line contains | then split the line and store the data in the array
                        if (line.Contains("|"))
                        {
                           

                            

                            string[] parts = line.Split('|');
                            string type = parts[0];
                            string title = parts[1];
                            int year = int.Parse(parts[2]);
                            string author = parts[3];
                            string summary = null;
                            string artist = null;
                            if (type == "SONG")
                            {
                                artist = parts[4];
                            }
                            else
                            {
                                summary = read.ReadLine(); 
                            }


                            //create an object of the media class and store the data in it and increment the counter
                            switch (type)
                            {
                                case "BOOK":
                                    
                                    media[counter] = new Book(author, summary, title, year);
                                    

                                    counter++;
                                    break;

                                case "MOVIE":
                                    
                                    media[counter] = new Movie(author, summary, title, year);
                                   
                                    counter++;
                                    break;
                                case "SONG":
                                    media[counter] = new Song(title,artist , author , year);
                                    counter++;
                                    break;



                                default:
                                    Console.WriteLine($"Unknown media type: {type}");
                                    break;
                            }
                        }

                    }
                }
               // create a menu and display it
                string menu =
                       @"                                           MENU
                                                   1- list all Books
                                                   2- list all Movies
                                                   3- list all Songs
                                                   4- list all media
                                                   5- search all media by title
                                                   6- exit

                                                    select an option:";
                Console.WriteLine(menu);

                
                
                //read the option from the user and call the functions
                    int option = int.Parse(Console.ReadLine());

                    while (option != 6)
                    {
                        switch (option)
                        {
                        // list all books
                            case 1:

                                Console.WriteLine("list all Books");
                                ListAllBooks();


                                break;
                            //list all movies
                            case 2:
                                Console.WriteLine("list all Movies");
                                ListAllMovies();
                                break;
                            //list all songs
                            case 3:
                                Console.WriteLine("list all Songs");
                                ListAllSongs();
                                break;
                            //list all media
                            case 4:
                                Console.WriteLine("list all media");
                                ListAllMedia();
                                break;
                            //search by title
                            case 5:
                                Console.WriteLine("enter the title");
                                string title = Console.ReadLine();
                                for (int i = 0; i < counter; i++)
                                {
                                    if (media[i].Search(title))
                                    {

                                        //decrypt the summary and display the title and summary of the book or movie or song
                                        if (media[i] is Book book)
                                        {
                                            Console.WriteLine($"title:{media[i].Title}");
                                            Console.WriteLine($"summary:{book.Decrypt(book.Summary)}");
                                        Console.WriteLine("---------------------------------------------------");

                                    }
                                    else if (media[i] is Movie movie)
                                        {
                                            Console.WriteLine($"title:{media[i].Title}");
                                        Console.WriteLine($"summary:{movie.Decrypt(movie.Summary)}");
                                        Console.WriteLine("---------------------------------------------------");

                                    }
                                    else if (media[i] is Song song)
                                        {
                                            Console.WriteLine($"title:{media[i].Title}");
                                        Console.WriteLine("---------------------------------------------------");


                                    }

                                }
                                }


                                break;
                            default:
                                Console.WriteLine("invalid option");
                                break;
                        }
                        Console.WriteLine(menu);
                        option = int.Parse(Console.ReadLine());
                    }
                }
            //catch the exceptions and display the message
            catch (Exception e)
            {
                Console.WriteLine("something went wrong." + " " + e.Message);
            }
        }
        /// <summary>
        /// list all books function
        /// </summary>
        public void ListAllBooks()
        {
            for (int i = 0; i < counter; i++)
            {
                if (media[i] is Book book)
                {
                    Console.WriteLine($"Title:{book.Title}");
                    Console.WriteLine("---------------------------------------------------");


                }
            }
        }

        /// <summary>
        /// list all movies function
        /// </summary>
        public void ListAllMovies()
        {
            for (int i = 0; i < counter; i++)
            {
                if (media[i] is Movie movie)
                {
                    Console.WriteLine($"Title:{movie.Title}");
                    Console.WriteLine("---------------------------------------------------");

                }
            }
        }

        /// <summary>
        /// list all songs function
        /// </summary>
        public void ListAllSongs()
        {
            for (int i = 0; i < counter; i++)
            {
                if (media[i] is Song song)
                {
                    Console.WriteLine($"Title:{song.Artist}");
                    Console.WriteLine($"Author:{song.Album}");
                    Console.WriteLine($"Album:{song.Title}");
                    Console.WriteLine($"Year:{song.Year}");
                   
                    Console.WriteLine("---------------------------------------------------");

                }
            }
        }
        /// <summary>
        /// list all media function
        /// </summary>
        public void ListAllMedia()
        {

            for (int i = 0; i < counter; i++)
            {
                if (media[i] is Media x)
                    if (x is Book )
                    {
                        
                        Console.WriteLine($"title:{x.Title}(BOOK)");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    else if (x is Song) {
                        
                        Console.WriteLine($"title:{x.Title}(SONG)");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    else if (x is Movie)
                    {
                       
                        Console.WriteLine($"title:{x.Title}(MOVIE)");
                        Console.WriteLine("---------------------------------------------------");
                    }



            }
        }
     


    }

}
        
    


