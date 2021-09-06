using System.Collections.Generic;
using System;

namespace pa1
{
    public class Utilities
    {
        

        public static void DisplayMenu(){
            
            
            Console.WriteLine("1. Show All Posts");
            Console.WriteLine("2. Add a Post");
            Console.WriteLine("3. Delete a Post by ID");
            Console.WriteLine("4. Exit");
            
        }

        public static void ShowPosts(List<Post> posts){ 
//for each loop to display posts
            System.Console.WriteLine("\nPosts: \n");
            foreach(Post post in posts){
                Console.WriteLine(post.ToString());
            }

        }
        
         
    }
}