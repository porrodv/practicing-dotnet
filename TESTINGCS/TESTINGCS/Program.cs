using System;

namespace TESTINGCS
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodDB foodDB = new FoodDB();
            var foods = foodDB.GetFoods();

            foreach (var food in foods)
            {
                Console.WriteLine(food.name);
            }
        }
    }
}
