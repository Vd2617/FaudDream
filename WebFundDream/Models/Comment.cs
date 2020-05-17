using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebFundDream.Models
{
    public class Comment
    {
        String text;

        String author;
        
        uint like;
        
        uint dislike;
        
        DateTime commentDate;


        public Comment(string author,string text) {
           
            commentDate = new DateTime();
           
            commentDate = DateTime.Now;
           
            Author = author;

            Text = text;
            
            this.like = 0;
            
            this.dislike = 0;
            

        }
        public Comment() { 
        }

        public string Text { get => text; set => text = value; }
       
        public uint Like { get => like; }
        public void AddLike() { this.like = this.like++; }
       
        public uint Dislike { get => dislike; }
        public void AddDislike() { this.dislike = this.dislike++; }
        public string Author { get => author; set => author = value; }
        public DateTime CommentDate { get => commentDate; }
    }
}
