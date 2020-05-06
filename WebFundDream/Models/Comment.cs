using System;
using System.Collections.Generic;
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
        
      

        public string Text { get => text; set => text = value; }
       
        public uint Like { get => like; set => like = value; }
       
        public uint Dislike { get => dislike; set => dislike = value; }
       
        public string Author { get => author; set => author = value; }
    }
}
