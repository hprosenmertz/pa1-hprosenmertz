using System;
using System.IO;

namespace pa1
{
    public class PostFile
    {
        public string fileName {get; set;}




//get all listings from file (# delimnited)
        public Post[] GetAllListings(){   

            Listing[] allListings = new Listing[1000];  //create array of Listings
            Listing.SetCount(0);
            StreamReader inFile = new StreamReader("listings.txt"); //open file
            string line = inFile.ReadLine();
            while( line != null){
                string[] data = line.Split('#');    //# delimited
                int tempId = int.Parse(data[0]);
                double tempPrice = double.Parse(data[3]);
                bool tempAvail = bool.Parse(data[5]);
                allListings[Listing.GetCount()] = new Listing(tempId, data[1], data[2], tempPrice, data[4], tempAvail); //add new Listing to file
                Listing.IncCount();     //update count
                line = inFile.ReadLine();   //read next line
            }
            inFile.Close();     //close file
            return allListings; //return Listing array
        }

    }
}