using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    public abstract class GreenVeg : AbstractVegetable
    {
        private string _rigidity;
        private int _vitaminsAmount;
        
        public GreenVeg(int p, string m) : base(p,m) { }

        public string Rigidity
        {
            get { return _rigidity; }
            set { _rigidity = value; }
        }

        public int VitaminsAmount
        {
            get { return _vitaminsAmount; }
            set { _vitaminsAmount = value; }
        }

        public override void TypeOfLoading()
        {
            Console.WriteLine("Важная часть кода");
        }
    }
}
