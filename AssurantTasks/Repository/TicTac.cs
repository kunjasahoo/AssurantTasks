namespace AssurantTasks.Repository
{
    internal class TicTac : ITicTac
    {
        public void PrintTicTac()
        {
            try
            {
                int tic = 3, tac = 5;
                for (int i = 0; i <= 100; i++)
                {
                    if (i % tic == 0 && i % tac == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0 }{1,10} ", i, "TIC TAC");
                    }
                    else if (i % tic == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(i + " TIC");
                    }
                    else if (i % tac == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(i + " TAC");
                    }
                    else Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Message :" + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}
