namespace TickTackToeClass
{

    public class GameWinnerService : IGameWinnerService
    {
        const char NoWinner = ' ';
        public char Validate(char[,] gameboard)
        {
            char currentWinningSymbol = NoWinner;
            currentWinningSymbol = ValidateHorizontal(gameboard);
            if (currentWinningSymbol != NoWinner) { return currentWinningSymbol; }
            currentWinningSymbol = ValidateVertical(gameboard);
            if (currentWinningSymbol != NoWinner) { return currentWinningSymbol; }
            currentWinningSymbol = ValidateDiagonalLeft(gameboard);
            if (currentWinningSymbol != NoWinner) { return currentWinningSymbol; }
            currentWinningSymbol = ValidateDiagonalRight(gameboard);
            return currentWinningSymbol;
        }

        public char ValidateHorizontal(char[,] gameboard)
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameboard[i, 0] != ' ')
                {
                    if (gameboard[i, 0] == gameboard[i, 1] && gameboard[i, 1] == gameboard[i, 2])
                    {
                        return gameboard[i, 0];
                    }
                }

            }
            return NoWinner;
        }
        public char ValidateVertical(char[,] gameboard)
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameboard[0, i] != ' ')
                {
                    if (gameboard[0, i] == gameboard[1, i] && gameboard[1, i] == gameboard[2, i])
                    {
                        return gameboard[0, i];
                    }
                }

            }
            return NoWinner;
        }

        public char ValidateDiagonalLeft(char[,] gameboard)
        {
            if (gameboard[0, 0] != ' ')
            {
                if (gameboard[0, 0] == gameboard[1, 1] && gameboard[1, 1] == gameboard[2, 2])
                {
                    return gameboard[0, 0];
                }
            }
            return NoWinner;
        }

        public char ValidateDiagonalRight(char[,] gameboard)
        {
            if (gameboard[0, 2] != ' ')
            {
                if (gameboard[0, 2] == gameboard[1, 1] && gameboard[1, 1] == gameboard[2, 0])
                {
                    return gameboard[0, 2];
                }
            }
            return NoWinner;
        }


    }
}