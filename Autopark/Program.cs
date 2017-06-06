using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int vegetablesAmount;
            int veg;
            Salad salad = new Salad();
            
            vegetablesAmount = 8;

            Console.WriteLine("В салате: ");
            for (int i = 1; i <= vegetablesAmount; i++)
            {
                veg = i;
                switch (veg)
                {
                    case 1:
                        Cucumber cm = new Cucumber(rand.Next(70) + 40, "Огурец");
                        salad.AddVegetables(cm);
                        Console.WriteLine(cm.Name + ": " + cm.Caloricity + " ккал");
                        break;
                    case 2:
                        Cabbage cb = new Cabbage(rand.Next(100) + 60, "Капуста");
                        salad.AddVegetables(cb);
                        Console.WriteLine(cb.Name + ": " + cb.Caloricity + " ккал");
                        break;
                    case 3:
                        Paprika p = new Paprika(rand.Next(50) + 20, "Перец");
                        salad.AddVegetables(p);
                        Console.WriteLine(p.Name + ": " + p.Caloricity + " ккал");
                        break;
                    case 4:
                        Tomato t = new Tomato(rand.Next(70) + 50, "Помидор");
                        salad.AddVegetables(t);
                        Console.WriteLine(t.Name + ": " + t.Caloricity + " ккал");
                        break;
                }
            }
            
            int Caloricity = salad.CountCaloricity();
            Console.WriteLine("Общая калорийность салата: " + Caloricity + " ккал");
            Console.ReadKey();
        }
    }
}
