namespace Assignments_SearchingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInts = { 5,8,4,3,0,1,7,6,10,50,40,60,20};
            //LinearSearch ls = new LinearSearch();
            JumpSearch js = new JumpSearch();
            Console.Write("Enter Target Element: ");
            int target =int.Parse(Console.ReadLine());
            //Console.WriteLine(target+" is located at index: "+ls.linear_search(arrayInts, target));
            Array.Sort(arrayInts);
            
            Console.Write("Sorted Array: ");
            foreach(int i in arrayInts)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine(target + " is found at index: " + js.jump_search(arrayInts, target)+" using jump search");
        }
    }
}
