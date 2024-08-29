namespace Bitwise_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitwise bitwise = new Bitwise();
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary Representation: "+bitwise.convert_to_binary(number));
            Console.WriteLine("Number of set bits in "+number+": " + bitwise.find_set_bits(number));
            Console.WriteLine("------------Swap bits---------------");
            Console.WriteLine("enter 1st position to swap:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2st position to swap:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(bitwise.swap_in_binary(number, a, b));
            Console.WriteLine("---------Find 2 non repeating numbers from an array--------");
            int[] arr = { 1, 2, 1, 2, 3, 4 };
            var result = bitwise.find_unique_non_repeating(arr);
            Console.WriteLine("The 2 non repeating numbers are: " + result[0] + " and " + result[1]);
        }
    }
}
