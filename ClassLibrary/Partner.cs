using System;
using System.Collections.Generic;
using System.Text;
namespace ClassLibrary
{
    public class Partner
    {
        public Partner(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public static void PrintPartner(string name)
        {
            Console.WriteLine("Hello " + name);
        }

    }
}
