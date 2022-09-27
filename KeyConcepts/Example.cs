namespace KeyConcepts
{
    //struct type is a value type that can encapsulate data and related functionality.
    //Typically, you use structure types to design small data-centric types that provide little or no behavior.
    public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"({X}, {Y})";
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    enum ErrorCode : ushort
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200
    }

    public class EnumConversionExample
    {
        public static void Main()
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

            var b = (Season)1;
            Console.WriteLine(b);  // output: Summer

            var c = (Season)4;
            Console.WriteLine(c);  // output: 4
        }
    }
}
