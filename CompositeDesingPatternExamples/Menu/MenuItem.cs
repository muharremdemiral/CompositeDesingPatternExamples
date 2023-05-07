using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExample
{
    class MenuItem : IComponent
    {
        private string _name;
        private double _price;

        public MenuItem(string name, double price)
        {
            _name = name;
            _price = price;
        }
        
        public void Display(string indentation = "")
        {
            Console.WriteLine($"    {_name} : {_price} TL");
        }
    }
}
