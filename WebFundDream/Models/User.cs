using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFundDream.Models
{
    public class User
    {
        String userinfo;

        String PayAccaunt;

        List<Company> companies;

        public List<Company> Companies { get => companies; set => companies = value; }
    }
}
