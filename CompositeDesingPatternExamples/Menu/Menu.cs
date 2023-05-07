using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuExample
{
    public class Menu : IComponent
    {
        private List<IComponent> _menuItems = new List<IComponent>();
        private string _name;

        public Menu(string name)
        {
            _name = name;
        }

        public void Add(IComponent component)
        {
            _menuItems.Add(component);
        }

        public void Remove(IComponent component)
        {
            _menuItems.Remove(component);
        }
        
        public void Display(string indentation = "")
        {
            Console.WriteLine($"{indentation}{_name}");

            if (_menuItems.Count <= 0) return;
            
            foreach (var item in _menuItems)
            {
                item.Display("  ");
            }
        }
    }
}
