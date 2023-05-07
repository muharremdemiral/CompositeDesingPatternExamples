using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExample
{
    public interface IComponent
    {
        void Display(string indentation = "");
    }
}
