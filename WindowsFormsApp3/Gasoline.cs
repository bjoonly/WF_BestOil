using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Gasoline
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public Gasoline(string name,double price)
        {
            Name = name;
            Price = price;
        }
        
    }
}
