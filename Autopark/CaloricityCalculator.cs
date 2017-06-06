using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class CaloricityCalculator
    {
        public int GetCaloricity(AbstractVegetable Veg)
        {
            int Caloricity;
            Caloricity = Veg.Caloricity;
            return Caloricity;
        }
    }
}
