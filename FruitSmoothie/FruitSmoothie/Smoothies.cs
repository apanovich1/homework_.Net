namespace FruitSmoothie
{
    public class Smoothies
    {
        public static Dictionary<string, decimal> Prices = new()
        {
            { "Strawberries", 1.50m },
            { "Banana", 0.50m },
            { "Mango", 2.50m },
            { "Blueberries", 1.00m },
            { "Raspberries", 1.00m },
            { "Apple", 1.75m },
            { "Pineapple", 3.50m }
        };

        public string[] Ingredients { get; set; }

        public Smoothies(string[] ingredients)
        {
            Ingredients = ingredients;
        }

        public decimal GetCost()
        {
            var sum = 0m;
            foreach (var cost in Ingredients)
            {
                sum += Prices[cost];
            }
            return sum;
        }

        public decimal GetPrice()
        {
            var finalSum = 0m;
            finalSum = GetCost() * 2.5m;
            return finalSum;
        }

        public string GetName()
        {
            var name = "";

            Array.Sort(Ingredients);

            for (var ingridient = 0; ingridient < Ingredients.Length; ingridient++)
            {
                if (Ingredients[ingridient] == "Strawberries")
                {
                    name += "Strawberry ";
                }

                else if (Ingredients[ingridient] == "Blueberries")
                {
                    name += "Blueberry ";
                }

                else if (Ingredients[ingridient] == "Raspberries")
                {
                    name += "Raspberry ";
                }

                else
                {
                    name += Ingredients[ingridient] + " ";
                }

            }

            if (Ingredients.Length == 1)
            {
                name += "Smoothie";
            }

            else
            {
                name += "Fusion";
            }

            return name;
        }
    }
}