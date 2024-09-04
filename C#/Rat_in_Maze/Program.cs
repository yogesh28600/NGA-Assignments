namespace Rat_in_Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[,] maze = { { 1,0,0,0},{1,1,0,1 },{1,1,0,0 },{0,1,1,1 } };
            int[,] maze =
            {
                {1,1,1,1,1,1,0,0 },
                {1,0,1,1,0,1,0,0 },
                {1,1,1,0,1,1,1,1 },
                {0,0,1,1,0,1,0,1 },
                {0,0,0,1,0,0,1,1 },
                {0,0,0,1,1,1,1,0 },
                {0,0,0,0,0,1,1,0 },
                {0,0,0,0,0,1,1,1 },
            };
            RatInMaze rim = new RatInMaze(maze);
            Console.WriteLine("Given Maze:");
            for(int i = 0;i< maze.GetLength(0); i++)
            {
                
                for(int j = 0; j < maze.GetLength(0);j++)
                {
                    Console.Write(maze[i,j]+"  ");
                }
                Console.WriteLine();
            }
            var result = rim.find_possible_paths();
            Console.WriteLine($"The possible paths are: {result.Count}");
            foreach (var path in result)
            {
                Console.Write("Path: ");
                foreach (var item in path)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
