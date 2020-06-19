using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture
{
    public class Options
    {
        public Options()
        {
            CarOptions = new List<string>();
        }
        public List<string> CarOptions { get; set; }
    }
}
