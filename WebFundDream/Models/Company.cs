using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFundDream.Models
{
   

    public class Company
    {
        List<Comment> comments;

        byte top;

        String name;

        String definition;

        List<String> bonuses;

        String them;

        decimal necessarysumm;

        decimal summ;

        byte progress;

        List<String> picturespaths;

        string videopath;

        DateTime datestart;

        DateTime dateend;

        public Company() {

            this.datestart = new DateTime();
            
            this.datestart = DateTime.Now;

            this.picturespaths = new List<string>();

            this.comments = new List<Comment>();

            this.bonuses = new List<string>();

        }

        public List<Comment> Comments { get => comments; set => comments = value; }
       
        public byte Top { get => top; set => top = value; }
       
        public string Name { get => name; set => name = value; }
        
        public string Definition { get => definition; set => definition = value; }
        
        public string Them { get => them; set => them = value; }
        
        public decimal Necessarysumm { get => necessarysumm; set => necessarysumm = value; }
        
        public decimal Summ { get => summ; set => summ = value; }

        public byte GetProgress()
        {
            this.progress = (byte)(Summ / (byte)Necessarysumm * 100);
            return progress;

        }

        public List<string> Pictures { get => picturespaths; set => picturespaths = value; }
        
        public DateTime Datestart { get => datestart; }
        
        public DateTime Dateend { get => dateend; set => dateend = value; }
        
        public string Videopath { get => videopath; set => videopath = value; }
        public List<string> Bonuses { get => bonuses; set => bonuses = value; }
    }
}
