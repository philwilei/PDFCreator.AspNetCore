using System;
using System.Collections.Generic;
using System.Text;

namespace PDFCreator.AspNetCore.Options
{
    class OptionFlag : Attribute
    {
        public string Name { get; private set; }

        public OptionFlag(string name)
        {
            Name = name;
        }
    }
}