using System;

class tic_tac_toe
{

    static void Main()
    {
        char[] position_array = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        Console.WriteLine("Welcome to tic-tac-toe!");
        Console.WriteLine("\t|\t|");
        Console.WriteLine("  - - - + - - - + - - - ");
        Console.WriteLine("\t|\t|");
        Console.WriteLine("  - - - + - - - + - - - ");
        Console.WriteLine("\t|\t|");
        for (int i = 1; i <= 9; i++)
        {
            int index = 0;
        jump1:
        jump2:
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
            {
                Console.Write("X's move >");
                index = Convert.ToInt32(Console.ReadLine());
                if (index < 0 || index > 9)
                {
                    Console.WriteLine("Illgel move! try again.");
                    goto jump1;
                }

                if (index >= 1 && index <= 9)
                {

                    if (position_array[index - 1] == ' ')
                    {
                        position_array[index - 1] = 'X';
                        Console.WriteLine("     |     |      ");
                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[0], position_array[1], position_array[2]);
                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                        Console.WriteLine("     |     |      ");
                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[3], position_array[4], position_array[5]);
                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                        Console.WriteLine("     |     |      ");
                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[6], position_array[7], position_array[8]);
                        Console.WriteLine("     |     |      ");


                    }
                    else
                    {
                        Console.WriteLine("Illgel move! try again.");
                        goto jump1;
                    }
                }
            }
            else
            {
                Console.Write("O's move >");
                index = Convert.ToInt32(Console.ReadLine());
                if (index < 0 || index > 9)
                {
                    Console.WriteLine("Illgel move! try again.");
                    goto jump2;
                }
                if (index >= 1 && index <= 9)
                {

                    if (position_array[index - 1] == ' ')
                    {
                        position_array[index - 1] = 'O';
                        Console.WriteLine("     |     |      ");
                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[0], position_array[1], position_array[2]);
                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                        Console.WriteLine("     |     |      ");
                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[3], position_array[4], position_array[5]);
                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                        Console.WriteLine("     |     |      ");
                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[6], position_array[7], position_array[8]);
                        Console.WriteLine("     |     |      ");


                    }
                    else
                    {
                        Console.WriteLine("Illgel move! try again.");
                        goto jump2;
                    }

                }
            }
        }
        Console.WriteLine("Game Over!");
    }
}