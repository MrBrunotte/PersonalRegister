using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;

namespace PersonalRegister
{
    class Program
    {

        static void Main(string[] args)
        {
            personal();
        }
        
        static void personal()
        {
            List<string> personal = new List<string>();

            personal.Add("Stefan Brunotte 150000");
            personal.Add("Stefan Brunotte 160000");
            personal.Add("Stefan Brunotte 170000");
            personal.Add("Stefan Brunotte 180000");

            for (int i = 0; i < personal.Count; i++)
            {
                Console.WriteLine(personal[i]);
            }
        }
    }

     
}