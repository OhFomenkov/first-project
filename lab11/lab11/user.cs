using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        public string sex { get; set; }
        public string Birthday { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string adress { get; set; }
        public string phoneoperator { get; set; }
        public string stage { get; set; }
        public string car { get; set; } = "Не имеет авто";
        public List<string> DriverCategory { get; set; } = new List<string>();
        public string CV { get; set; }
        public int minzp { get; set; }
        public int maxzp { get; set; }
    }
}
