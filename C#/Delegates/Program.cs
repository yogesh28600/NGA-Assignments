namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntToStringDelegate its = new IntToStringDelegate(convert);
            its += convert_and_print;
            List<int> list = new List<int>() { 123, 224, 563, 667, 890 };
            foreach (int i in list)
            {
                its(i);
            }
            
        }
        static string convert(int i)
        {
            return "string"+i;
        }
        static string convert_and_print(int i)
        {

            string str = "string " + i;
            Console.WriteLine(str);
            return str;
        }
    }
}
