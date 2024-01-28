namespace GA_StringParsing_Salvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber = int.Parse("12");
            double doubleNumber = double.Parse("5.23");
            bool trueOrFalse = bool.Parse("true");

            string string12 = "12";
            int number12 = int.Parse(string12);
            int addValue = number12 + number12;
            Console.WriteLine(addValue);
        }
    }
}
