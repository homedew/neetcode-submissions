public class Solution {
    private int rows, cols;
    private bool[,] visited;
    public bool Exist(char[][] board, string word) {
        rows = board.Length;
        cols = board[0].Length;
        visited = new bool[rows, cols];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0;  j< cols; j++)
            {
                if(Dfs(board, i, j , word, 0)) return true;
            }
        }

        return false;
    }

    private bool Dfs(char[][] board, int row, int col, string word, int k)
    {
        if(word.Length == k) return true;

        if(col >= cols || col <0 || row >= rows || row <0 || word[k] != board[row][col] || visited[row,col]) return false;

        visited[row, col] = true;
        bool rs = Dfs(board, row + 1, col, word, k + 1) ||
                    Dfs(board, row -1, col, word, k + 1) ||
                    Dfs(board, row , col + 1, word, k + 1) ||
                    Dfs(board, row , col - 1, word, k + 1) ;
        visited[row, col] = false;

        return rs;

    }
}
