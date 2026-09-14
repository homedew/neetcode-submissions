public class Solution {
    private int rowRaw =0;
    private int colRaw = 0;
    private bool[,] visited;

    private bool Dfs(int row, int col, char[][] board, string word, int k)
    {
        
        if(word.Length == k) return true;

        if(row < 0 || col < 0 || row >= rowRaw || col >= colRaw  
        || board[row][col] != word[k] || visited[row,col]) return false;
        
        visited[row, col] = true;
        
        bool rs = Dfs(row + 1, col, board, word, k + 1) ||
                    Dfs(row -1, col, board, word, k + 1) ||
                    Dfs(row , col+ 1, board, word, k + 1) ||
                    Dfs(row , col - 1, board, word, k + 1);
        visited[row, col] =false;

        return rs;
    }

    public bool Exist(char[][] board, string word) {
        rowRaw = board.Length;
        colRaw = board[0].Length;
        visited = new bool[rowRaw, colRaw];

        for( int  i = 0; i < rowRaw; i++)
        {
            for(int j = 0; j < colRaw; j++)
            {
                if(Dfs(i, j, board, word, 0)) return true;
            }
        }

        return false;
    }
}
