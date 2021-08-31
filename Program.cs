
using System;

namespace pa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Big Al Goes Social!");
            DisplayMenu();  //display menu
            int choice = UserChoice();  //get valid user choice
        }

        public static void DisplayMenu(){
            
            Console.WriteLine("Please enter the number of the menu item you would like to select:");
            Console.WriteLine("1. Show All Posts");
            Console.WriteLine("2. Add a Post");
            Console.WriteLine("3. Delete a Post by ID");
            Console.WriteLine("4. Exit");
            
        }

        public static int UserChoice(){

            int choice = int.Parse(Console.ReadLine());
            while(choice != 1 && choice != 2 && choice != 3 && choice != 4){
                 try{ //try statement
                    Console.WriteLine("Invalid Choice.");
                    DisplayMenu();
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

        public static void MenuActions(int choice){

            switch(choice){
                case 1: //Show All Posts
                    ShowPosts();

                case 2: //Add a Post
                    AddPost();

                case 3: //Delete Post
                    DeletePost();
         
                case 4: //exit
                    break;

            }
        }






    }
}
