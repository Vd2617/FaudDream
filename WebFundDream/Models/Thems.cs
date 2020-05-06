using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFundDream.Models
{
    public class Them
    {
        List<String> thems;

        public  Them (){

            thems = new List<string>();
            
            this.Thems.Add("Arts");
            
            this.Thems.Add("Music");
            
            this.Thems.Add("Film");
       }

        public List<string> Thems { get => thems; set => thems = value; }
    }
}
