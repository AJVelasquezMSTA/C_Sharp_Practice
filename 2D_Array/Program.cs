using System;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] M = new int[,] { { 1, 1, 0, 0, 0 },
                                  { 0, 1, 0, 0, 1 },
                                  { 1, 0, 0, 1, 1 },
                                  { 0, 0, 0, 0, 0 },
                                  { 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1 }};

            Console.WriteLine("Number of islands is: \t"+ CountIslands(M));
            Console.WriteLine("Number of rows in M is: \t" + M.GetLength(0));

        }


        public static int CountIslands(int[,] M)
        {
            int ROW = M.GetLength(0);
            int COL = M.GetLength(1);
            //bool array to mark visited cells. Initially, all cells are unvisited
            bool[,] visited = new bool[ROW, COL];

            //initialize count as 0 and traverse through the all cells of given matrix
            int count = 0;
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (M[i, j] == 1 && !visited[i, j])
                    {
                        DFS(M, i, j, visited);
                        count++;
                    }
                }
            }
            return count;
        }

        //A utility to do DFS for a 2D boolean matrix
        //It only considers the 8 neighbors as adjacent vertices
        private static void DFS(int[,] M, int row, int col, bool[,] visited)
        {
            //These arrays are used to get row and column numbers
            //of 8 neighbors of a given cell
            int[] rowNr = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colNr = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

            //Mark this cell as visited
            visited[row, col] = true;

            //Recur for all connected neighbors
            for (int k = 0; k < rowNr.Length; k++)
            {
                if (isSafe(M, row + rowNr[k], col + colNr[k], visited))
                {
                    DFS(M, row + rowNr[k], col + colNr[k], visited);
                }
            }
        }

        //A function to check if a given cell(row,col) can be included in DFS
        private static bool isSafe(int[,] M, int row, int col, bool[,] visited)
        {
            int ROW = M.GetLength(0);
            int COL = M.GetLength(1);

            // row number is in range, column number is in range, and value is 1 and not visited
            return (row >= 0) && (row < ROW) && (col >= 0) && (col < COL) && (M[row, col] == 1 && !visited[row, col]);
        }
    }
}
