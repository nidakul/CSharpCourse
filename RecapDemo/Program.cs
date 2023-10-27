//for Mac

int[,] board = new int[8, 8];

for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if ((i + j) % 2 == 0)
        {
            board[i, j] = 1;
        }
        else
        {
            board[i, j] = 2;
        }
    }
}

for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if (board[i, j] == 1)
        {
            Console.Write("W");
        }
        else
        {
            Console.Write("B");
        }
    }
    Console.WriteLine();
}



