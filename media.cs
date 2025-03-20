using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
    
    public class Media
    {

        
        public string Title {  get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public bool IsAvailable { get; set; }

        public bool GetAvailable()
        {
            return IsAvailable;
        }
        public void SetAvailable(bool val)
        {
            IsAvailable = val;
        }

    }
}
