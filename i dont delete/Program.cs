using i_dont_delete;

namespace program;

public static class program
{
    static void Main(string[] args)
    {
        
        int[,] board = new int[6, 6];
        int row, col;
        int number;
        House[] houses=new House[6];
        for (int i = 0; i < 6; i++)
        {
            houses[i] = new House(new List<Tile>());
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {    
            
            }
        }
        newboard(board);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.Black;
        board[0, 1] = 3;
        board[0, 2] = 5;
        board[0, 4] = 2;
        board[0, 5] = 6;
        board[1, 0] = 6;
        board[1, 1] = 1;
        board[2, 2] = 4;
        board[2, 5] = 3;
        board[3, 1] = 2;
        board[3, 4] = 6;
        board[4, 2] = 6;
        board[4, 3] = 4;
        board[4, 4] = 3;
        board[4, 5] = 1;
        board[5, 0] = 3;
        board[5, 1] = 4;
        board[5, 5] = 2;
        print(board);

        for (int i = 0; i < 19; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the row!");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the col!");
            col = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number!");
            number = int.Parse(Console.ReadLine());
            while (number < 1 || number > 6)
            {
                Console.WriteLine("impossible,plz enter the number again!");
                number = int.Parse(Console.ReadLine());
            }


            board[row - 1, col - 1] = number;
            Console.WriteLine();
            print(board);
        }


    }
    static void print(int[,] board)
    {
        int counter = 0;
        int mone = 0;
        Console.WriteLine("  | 1 | 2 | 3 | 4 | 5 | 6 | ");
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            Console.Write((mone / 6) + 1 + " | ");

            for (int j = 0; j < 6; j++)

            {
                Console.Write(board[i, j]);
                if ((mone + 1) % 3 != 0)
                    Console.Write(" : ");
                else
                {
                    Console.Write(" | ");
                }
                mone++;
            }
            Console.WriteLine();
            if (counter % 2 != 0)
            {
                Console.WriteLine();
            }
            counter++;
        }
    }
    static void newboard(int[,] board)
    {

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                board[i, j] = 0;

            }
        }

        //Console.WriteLine("hi");
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("hi");


    }
}
