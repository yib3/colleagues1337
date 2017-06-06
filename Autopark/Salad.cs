using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{   
     public class Salad
    {
        private int vegetablesAmount = 0;
        private int countCaloricity = 0;
        CaloricityCalculator calculator = new CaloricityCalculator();
    

        protected List<AbstractVegetable> list_of_vegetables = new List<AbstractVegetable>();

        public int CountCaloricity()
        {
            for (int i = 0; i < list_of_vegetables.Count; i++)
            {
                countCaloricity = countCaloricity + calculator.GetCaloricity(list_of_vegetables[i]);
            }
            return countCaloricity;
        }
        

        public void AddVegetables(AbstractVegetable _veg)
        {
            list_of_vegetables.Add(_veg);
            vegetablesAmount += 1;
        }
    }
}
