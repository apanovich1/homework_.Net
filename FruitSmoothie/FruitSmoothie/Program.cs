
namespace FruitSmoothie
{
    public static class Program
    {
        static void Main()
        {
            Smoothies mySmoothie = new Smoothies(new string[] { "Strawberries" });
            Console.WriteLine(mySmoothie.GetCost().ToString());
            Console.WriteLine(mySmoothie.GetPrice().ToString());
            Console.WriteLine(mySmoothie.GetName().ToString());
        }
    }
}

//class smoothie в отдельный проект