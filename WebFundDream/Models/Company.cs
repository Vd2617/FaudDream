using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebFundDream.Models
{
   

    public class Company
    {
        String commentsJson;
       
        int id;
        
        byte top;

        String name;

        String definition;

        String  bonusesJson;

        String them;

        decimal necessarysumm;

        decimal summ;

        byte progress;

        String picturespathsJson;

        String videopath;

        DateTime datestart;

        DateTime dateend;

        public Company() {

            this.datestart = new DateTime();
            
            this.datestart = DateTime.Now;

            commentsJson = "";
            
            top = 0;

         }

       
       
        public byte Top { get => top; set => top = value; }
       
        public String Name { get => name; set => name = value; }
        
        public String Definition { get => definition; set => definition = value; }
        
        public String Them { get => them; set => them = value; }
        
        public decimal Necessarysumm { get => necessarysumm; set => necessarysumm = value; }
        
        public decimal Summ { get => summ; set => summ = value; }

        public byte GetProgress()
        {
            this.progress = (byte)(Summ / (byte)Necessarysumm * 100);
            return progress;

        }

      
        
        public DateTime Datestart { get => datestart; }
        
        public DateTime Dateend { get => dateend; set => dateend = value; }
        
        public String Videopath { get => videopath; set => videopath = value; }
        public int Id { get => Id; set => Id = value; }
       

        public List<Comment> CommentsJsonDeserialized() {
            return JsonSerializer.Deserialize<List<Comment>>(this.commentsJson);
        }
        public void CommentsJsonSerialized(List<Comment> comments)
        {
            this.commentsJson = JsonSerializer.Serialize<List<Comment>>(comments);
        }

        public List<String> BonusesJsonDeserialized()
        {
            return JsonSerializer.Deserialize<List<String>>(this.bonusesJson);
        }
        public void CommentsJsonSerialized(List<String> bonuses)
        {
            this.bonusesJson = JsonSerializer.Serialize<List<String>>(bonuses);
        }
        public List<String> PicturesPathJsonDeserialized()
        {
            return JsonSerializer.Deserialize<List<String>>(this.picturespathsJson);
        }
        public void PicturesPathJsonSerialized(List<String> pictures)
        {
            this.picturespathsJson = JsonSerializer.Serialize<List<String>>(pictures);
        }
    }
}
