using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    public abstract class AbstractVegetable
    {
        private string _name;
        private int _caloricity;
        
        public AbstractVegetable(int p, string m)
        {
            this.Caloricity = p;
            this.Name = m;
        }

        public abstract void TypeOfLoading();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Caloricity
        {
            get { return _caloricity; }
            set { _caloricity = value; }
        }          
    }
}
