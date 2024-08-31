namespace Knakspak_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Objects obj1 = new Objects('A', 1, 6);
            Objects obj2 = new Objects('B', 2, 10);
            Objects obj3 = new Objects('C', 4, 8);
            Objects obj4 = new Objects('D', 2, 4);
            Objects obj5 = new Objects('E', 6, 12);
            Objects obj6 = new Objects('F', 7, 14);
            Objects obj7 = new Objects('G', 1, 2);

            Objects[] objects  = { obj1, obj2, obj3, obj4, obj5, obj6, obj7 };
            Console.WriteLine("profit/weight as consideration");
            Knakspak knakspak = new Knakspak(16);
            knakspak.knakspak_algo(objects);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Weight as consideration");
            Knakspak knakspak1 = new Knakspak(16);
            knakspak1.knakspak_algo_with_weight(objects);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("profit as consideration");
            Knakspak knakspak2 = new Knakspak(16);
            knakspak2.knakspak_algo_with_profit(objects);
        }
    }
}
