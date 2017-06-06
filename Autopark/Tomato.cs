using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Tomato : RedVeg
    {
        public Tomato(int p, string m) : base(p,m) { }

        private string _tasteSaturation;

        public string TasteSaturation
        {
            get { return _tasteSaturation; }
            set { _tasteSaturation = value; }
        }
    }
}
