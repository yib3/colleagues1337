using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Cabbage : GreenVeg
    {
        public Cabbage(int p, string m) : base(p,m) { }

        private string _sphericity;

        public string Sphericity
        {
            get { return _sphericity; }
            set { _sphericity = value; }
        }
    }
}
