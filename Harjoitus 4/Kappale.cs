using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4
{
    class Kappale
    {
        private string name { get; set; }
        private string length { get; set; }

        public Kappale(string _name, string _length)
        {
            name = _name;
            length = _length;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", name, length);
        }
    }
}
