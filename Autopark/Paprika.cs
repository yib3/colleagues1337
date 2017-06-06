using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Paprika : RedVeg
    {
        private string _burning;

        public Paprika(int p, string m) : base(p,m) { }

        public string Burning
        {
            get { return _burning; }
            set { _burning = value; }
        }        
    }
}
