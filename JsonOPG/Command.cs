using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace JsonOPG
{
    public class Command
    {
        public string Method { get; set; }  
        public int Number1 { get; set; }
        public int Number2 { get; set; }


        public Command()
        {
            
        }


        public Command(string method, int number1, int number2)
        {
            Method = method;
            Number1 = number1;
            Number2 = number2;

        }

    }
}
