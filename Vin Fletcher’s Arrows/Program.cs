//Biruk Simachew
//2/13/25
namespace Vin_Fletcher_s_Arrows
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrowheadType arrowhead = GetArrowheadType();
            FletchingType fletching = GetFletchingType();
            float length = GetShaftLength();

            Arrow arrow = new Arrow(arrowhead, fletching, length);
            float cost = arrow.CalculateCost();

            Console.WriteLine($"The cost of the arrow is {cost} gold.");
            Console.WriteLine($"Arrow details: {arrow.Arrowhead} arrowhead, {arrow.Fletching} fletching, {arrow.Length} cm length.");
        }

        private static ArrowheadType GetArrowheadType()
        {
            Console.WriteLine("Choose an arrowhead type: Steel, Wood, Obsidian");
            return (ArrowheadType)Enum.Parse(typeof(ArrowheadType), Console.ReadLine(), true);
        }

        private static FletchingType GetFletchingType()
        {
            Console.WriteLine("Choose a fletching type: Plastic, TurkeyFeathers, GooseFeathers");
            return (FletchingType)Enum.Parse(typeof(FletchingType), Console.ReadLine(), true);
        }

        private static float GetShaftLength()
        {
            Console.WriteLine("Enter the length of the shaft (60 to 100 cm):");
            return float.Parse(Console.ReadLine());
        }
    }
    }

