using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class DarkTextBox : ITextBox
    {
        public string Display() => "Displaying dark text box";
    }
}