using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Cucumber : GreenVeg
    {       
        public Cucumber(int p, string m) : base(p,m) { }

        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }                
    }
}
