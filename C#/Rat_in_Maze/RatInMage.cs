using System;
using System.Collections.Generic;

namespace Rat_in_Maze
{
    public class RatInMaze
    {
        int[,] maze;
        List<List<char>> result = new List<List<char>>();
        int N;
        public RatInMaze(int[,] maze)
        {
            this.maze = maze;
            this.N = maze.GetLength(0);
        }
        private bool IsSafe(int i, int j)
        {
            return i >= 0 && i < N && j >= 0 && j < N && maze[i, j] == 1;
        }
        public List<List<char>> find_possible_paths()
        {
            if (maze == null || maze.GetLength(0) == 0)
                return result;
            bool[,] visited = new bool[N, N];
            List<char> path = new List<char>();
            helper(0, 0, path, visited);
            return result;
        }
        private void helper(int i, int j, List<char> path, bool[,] visited)
        {
            if (i == N - 1 && j == N - 1)
            {
                result.Add(new List<char>(path));
                return;
            }
            if (!IsSafe(i, j) || visited[i, j])
                return;
            visited[i, j] = true;
            if (IsSafe(i, j + 1))
            {
                path.Add('R');
                helper(i, j + 1, path, visited);
                path.RemoveAt(path.Count - 1);
            }
            if (IsSafe(i + 1, j))
            {
                path.Add('D');
                helper(i + 1, j, path, visited);
                path.RemoveAt(path.Count - 1);
            }
            if (IsSafe(i, j - 1))
            {
                path.Add('L');
                helper(i, j - 1, path, visited);
                path.RemoveAt(path.Count - 1);
            }
            if (IsSafe(i - 1, j))
            {
                path.Add('U');
                helper(i - 1, j, path, visited);
                path.RemoveAt(path.Count - 1);
            }
            visited[i, j] = false;
        }
    }
}
