using System.Collections.Generic;
using System;

namespace pa1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> posts = new List<Post>();
            
            Console.WriteLine("Welcome to Big Al Goes Social!");
            Utilities.DisplayMenu();  //display menu
            int choice = UserChoice();  //get valid user choice
            MenuActions(choice, posts);

            //handle error and ask user to do something else
            //keep asking user until they quit
        }
        

        public static int UserChoice(){
            Utilities utils = new Utilities();
            int choice = int.Parse(Console.ReadLine());
   
            while(choice != 1 && choice != 2 && choice != 3 && choice != 4){
                 try{ //try statement
                    Console.WriteLine("Invalid Choice.");
                    Utilities.DisplayMenu();
                    choice = int.Parse(Console.ReadLine());

                    if(choice < 1 || choice > 4){
                        throw new Exception("Invalid input outside of range.");  
                    }
                }
                catch(Exception e){ 
                    System.Console.WriteLine(e.Message);    
                }
            }
            return choice;
        }

        public static void MenuActions(int choice, List<Post> posts){
           // Utilities utils = new Utilities();
            switch(choice){
                //get posts from file
                case 1: //Show All Posts
                    posts = PostFile.GetPosts(); 
                    Utilities.ShowPosts(posts);
                    break;
                case 2: //Add a Post
                    PostFile.AddPost();
                    break;
                case 3: //Delete Post
                    posts = PostFile.GetPosts(); 
                    PostFile.DeletePost(posts);
                    break;
                case 4: //exit
                    break;
            }
        }







    }
}
