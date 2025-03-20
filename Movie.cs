using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Movie : Media
    {
        public int DurationMin { get; set; }
        public string Director {  get; set; }   
    }
}
