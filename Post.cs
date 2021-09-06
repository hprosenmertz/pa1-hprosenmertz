using System;
using System.IO;

namespace pa1
{
    public class Post
    {
         public int PostID {get; set;}
         public string Text {get; set;}
         public string DateTime {get; set;}


        public static int CompareByTime(Post x, Post y){ 
            
            return y.DateTime.CompareTo(x.DateTime);
        }

        public override string ToString()
        {
            return "Post ID: " + this.PostID + " Post: " + this.Text + " Timestamp: " + this.DateTime;
        }

    }
}