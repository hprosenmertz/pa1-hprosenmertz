using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;


namespace pa1
{
    public class PostFile
    {

        public static List<Post> GetPosts(){
            List<Post> posts = new List<Post>();
            StreamReader inFile = null; //need to initialize outside of try {}

            //try-catch for error handling
            try{
                inFile = new StreamReader("posts.txt");
            }
            catch(FileNotFoundException e){
                Console.WriteLine("Something went wrong... File Not Found\n", e);
                // System.Console.WriteLine("Try adding a post to the file!");
                return posts;
            }

            string line = inFile.ReadLine(); //priming read
            while(line!=null){
                string[] temp = line.Split("#");
                int postID = int.Parse(temp[0]);
                //method call to add object to list
                posts.Add(new Post() {PostID = postID, Text = temp[1], DateTime = temp[2]});
                line = inFile.ReadLine();  //update read
            }
            inFile.Close();

            return posts;
        }

//Add Post

        public static void AddPost(){
            StreamWriter addFile = new StreamWriter("posts.txt", true);

            Console.WriteLine("ADDING A NEW POST");  //get all info from operator
            int postID = IDGenerator();
            System.Console.WriteLine("Please enter the text for the post: ");
            string text = Console.ReadLine();
            DateTime dateTime = DateTime.Now;   //get date and time stamp
            string timeStamp = dateTime.ToString();

            addFile.WriteLine($"{postID}#{text}#{timeStamp}");  //write into listing file
            addFile.Close();
        }

        public static int IDGenerator(){   //creates post ID every time a new post is added
           
            int newId =0;
            int lastId;
            List<Post> posts = new List<Post>();
            StreamReader inFile = new StreamReader("posts.txt");     //open file
            string line = inFile.ReadLine();    //read in first line

            if(line == null){   //check if this is the first listing
                Random randomNum = new Random();
                newId+= randomNum.Next(10); //creates 1st listing Id
            }
            else{
                List<Post> allPosts = GetPosts();
                Post temp = allPosts.Last(); //get last post in list
                lastId = temp.PostID;  //get id from last post
                Random randomNum = new Random();
                newId = lastId; //update newId
                newId+= randomNum.Next(1,10);
            }
            return newId;
        }

//DELETE POST
//remove post from array and update file
        public static void DeletePost(List<Post> post){

            StreamReader inFile = null; 
            try{
                inFile = new StreamReader("posts.txt");
            }
            catch(FileNotFoundException){
                System.Console.WriteLine("There are no posts to delete");
                return;
            }
            
            Console.WriteLine("\nEnter the ID number of the post you would like to delete:");
            int deleteId = int.Parse(Console.ReadLine());

        
            post.Remove(new Post() {PostID = deleteId});
            for (int i = post.Count-1; i >=0; i--){
                if (post[i].PostID == deleteId){
                        post.RemoveAt(i);
                    }
            }
         

           UpdateFile(post);   //update file

        }
        public static void UpdateFile(List<Post> posts){
           
            StreamWriter updateFile = new StreamWriter("posts.txt");
            foreach(Post post in posts){
                updateFile.WriteLine($"{post.PostID}#{post.Text}#{post.DateTime}");
            }
            updateFile.Close();
        }

        


    }
}