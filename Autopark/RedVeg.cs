using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    public abstract class RedVeg : AbstractVegetable
    {
        private string _shape;
        private int _ossiclesAmount;

        public RedVeg(int p, string m) : base(p, m) { }

        public string Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }

        public int OssiclesAmount
        {
            get { return _ossiclesAmount; }
            set { _ossiclesAmount = value; }
        }

        public override void TypeOfLoading()
        {
            Console.WriteLine("Важная часть кода");
        }
    }
}
