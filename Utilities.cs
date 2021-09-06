using System.Collections.Generic;
using System;

namespace pa1
{
    public class Utilities
    {
        
        
        public static void PrintAllPosts(List<Post> posts){ //class method
     

            foreach(Post post in posts){
                Console.WriteLine(posts.ToString());
            }

        }

        public static void DisplayMenu(){
            
            Console.WriteLine("Please enter the number of the menu item you would like to select:");
            Console.WriteLine("1. Show All Posts");
            Console.WriteLine("2. Add a Post");
            Console.WriteLine("3. Delete a Post by ID");
            Console.WriteLine("4. Exit");
            
        }

        public static void ShowPosts(List<Post> posts){ 

            foreach(Post post in posts){
                Console.WriteLine(post.ToString());
            }

        }
        
         
    }
}