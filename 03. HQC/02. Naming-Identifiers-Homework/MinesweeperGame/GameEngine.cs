// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameEngine.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The game engine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MinesweeperGame
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The game engine.
    /// </summary>
    public class GameEngine
    {
        /// <summary>
        ///     The max.
        /// </summary>
        private const int Max = 35;

        /// <summary>
        ///     The champions.
        /// </summary>
        private readonly List<Ranking> champions = new List<Ranking>(6);

        /// <summary>
        ///     The column.
        /// </summary>
        private int column;

        /// <summary>
        ///     The command.
        /// </summary>
        private string command = string.Empty;

        /// <summary>
        ///     The counter.
        /// </summary>
        private int counter;

        /// <summary>
        ///     The flag.
        /// </summary>
        private bool flag = true;

        /// <summary>
        ///     The flag 2.
        /// </summary>
        private bool flag2;

        /// <summary>
        ///     The game field.
        /// </summary>
        private char[,] gameField = CreateGameField();

        /// <summary>
        ///     The grum.
        /// </summary>
        private bool grum;

        /// <summary>
        ///     The mines.
        /// </summary>
        private char[,] mines = SetMines();

        /// <summary>
        ///     The row.
        /// </summary>
        private int row;

        /// <summary>
        ///     The engine.
        /// </summary>
        public void Run()
        {
            do
            {
                if (this.flag)
                {
                    Console.WriteLine(
                        "Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki."
                        + " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    Dump(this.gameField);
                    this.flag = false;
                }

                Console.Write("Daj red i kolona : ");
                this.command = Console.ReadLine().Trim();
                if (this.command.Length >= 3)
                {
                    if (int.TryParse(this.command[0].ToString(), out this.row)
                        && int.TryParse(this.command[2].ToString(), out this.column)
                        && this.row <= this.gameField.GetLength(0) && this.column <= this.gameField.GetLength(1))
                    {
                        this.command = "turn";
                    }
                }

                switch (this.command)
                {
                    case "top":
                        GetRanking(this.champions);
                        break;
                    case "restart":
                        this.gameField = CreateGameField();
                        this.mines = SetMines();
                        Dump(this.gameField);
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (this.mines[this.row, this.column] != '*')
                        {
                            if (this.mines[this.row, this.column] == '-')
                            {
                                ChangeTurn(this.gameField, this.mines, this.row, this.column);
                                this.counter++;
                            }

                            if (Max == this.counter)
                            {
                                this.flag2 = true;
                            }
                            else
                            {
                                Dump(this.gameField);
                            }
                        }
                        else
                        {
                            this.grum = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (this.grum)
                {
                    Dump(this.mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", this.counter);
                    string nickName = Console.ReadLine();
                    Ranking t = new Ranking(nickName, this.counter);
                    if (this.champions.Count < 5)
                    {
                        this.champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < this.champions.Count; i++)
                        {
                            if (this.champions[i].Points < t.Points)
                            {
                                this.champions.Insert(i, t);
                                this.champions.RemoveAt(this.champions.Count - 1);
                                break;
                            }
                        }
                    }

                    this.champions.Sort(
                        (Ranking r1, Ranking r2) => string.Compare(r2.Player, r1.Player, StringComparison.Ordinal));
                    this.champions.Sort((Ranking r1, Ranking r2) => r2.Points.CompareTo(r1.Points));
                    GetRanking(this.champions);

                    this.gameField = CreateGameField();
                    this.mines = SetMines();
                    this.counter = 0;
                    this.grum = false;
                    this.flag = true;
                }

                if (this.flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvori 35 kletki bez kapka kryv.");
                    Dump(this.mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Ranking points = new Ranking(name, this.counter);
                    this.champions.Add(points);
                    GetRanking(this.champions);
                    this.gameField = CreateGameField();
                    this.mines = SetMines();
                    this.counter = 0;
                    this.flag2 = false;
                    this.flag = true;
                }
            }
 while (this.command != "exit");
        }

        /// <summary>
        /// Gets the ranking.
        /// </summary>
        /// <param name="points">
        /// The points.
        /// </param>
        private static void GetRanking(List<Ranking> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Player, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        /// <summary>
        /// Changes the turn.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        /// <param name="mines">
        /// The mines.
        /// </param>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <param name="column">
        /// The column.
        /// </param>
        private static void ChangeTurn(char[,] field, char[,] mines, int row, int column)
        {
            char numberOfMines = CountMines(mines, row, column);
            mines[row, column] = numberOfMines;
            field[row, column] = numberOfMines;
        }

        /// <summary>
        /// Dumps the specified board.
        /// </summary>
        /// <param name="board">
        /// The board.
        /// </param>
        private static void Dump(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColumns; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        /// <summary>
        ///     Creates the game field.
        /// </summary>
        /// <returns>Board matrix.</returns>
        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        /// <summary>
        ///     Sets the mines.
        /// </summary>
        /// <returns>Game field matrix with mines positions.</returns>
        private static char[,] SetMines()
        {
            int rows = 5;
            int colomuns = 10;
            char[,] gameField = new char[rows, colomuns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomuns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!mines.Contains(newMine))
                {
                    mines.Add(newMine);
                }
            }

            foreach (int mine in mines)
            {
                int column = mine/colomuns;
                int row = mine%colomuns;
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = colomuns;
                }
                else
                {
                    row++;
                }

                gameField[column, row - 1] = '*';
            }

            return gameField;
        }

        /// <summary>
        /// Calculates the specified field.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        private static void Calculate(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char count = CountMines(field, i, j);
                        field[i, j] = count;
                    }
                }
            }
        }

        /// <summary>
        /// Counts the mines.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        /// <param name="currentRow">
        /// The current row.
        /// </param>
        /// <param name="currentColumn">
        /// The current column.
        /// </param>
        /// <returns>
        /// Mines count.
        /// </returns>
        private static char CountMines(char[,] field, int currentRow, int currentColumn)
        {
            int mineCounter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (field[currentRow - 1, currentColumn] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (field[currentRow + 1, currentColumn] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentColumn - 1 >= 0)
            {
                if (field[currentRow, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentColumn + 1 < columns)
            {
                if (field[currentRow, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn - 1 >= 0))
            {
                if (field[currentRow - 1, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn + 1 < columns))
            {
                if (field[currentRow - 1, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn - 1 >= 0))
            {
                if (field[currentRow + 1, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn + 1 < columns))
            {
                if (field[currentRow + 1, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            return char.Parse(mineCounter.ToString());
        }
    }
}