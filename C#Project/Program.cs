using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class SudokuForm : Form
    {
        private const int GRID_SIZE = 9;
        private const int CELL_SIZE = 50;
        private const int BOARD_PADDING = 10;

        private TextBox[,] cells;
        private int[,] originalPuzzle;
        private int[,] solvedPuzzle;
        private Random random = new Random();

        public SudokuForm()
        {
            InitializeComponent();
            InitializeBoard();
            GenerateNewPuzzle();
        }

        private void InitializeComponent()
        {
            this.Text = "Sudoku Game";
            this.Size = new Size(GRID_SIZE * CELL_SIZE + BOARD_PADDING * 2 + 16,
                                GRID_SIZE * CELL_SIZE + BOARD_PADDING * 2 + 120);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add buttons
            Button newGameButton = new Button
            {
                Text = "New Game",
                Location = new Point(BOARD_PADDING, GRID_SIZE * CELL_SIZE + BOARD_PADDING + 10),
                Size = new Size(100, 30)
            };
            newGameButton.Click += NewGameButton_Click;
            this.Controls.Add(newGameButton);

            Button checkButton = new Button
            {
                Text = "Check",
                Location = new Point(BOARD_PADDING + 110, GRID_SIZE * CELL_SIZE + BOARD_PADDING + 10),
                Size = new Size(100, 30)
            };
            checkButton.Click += CheckButton_Click;
            this.Controls.Add(checkButton);

            Button solveButton = new Button
            {
                Text = "Solve",
                Location = new Point(BOARD_PADDING + 220, GRID_SIZE * CELL_SIZE + BOARD_PADDING + 10),
                Size = new Size(100, 30)
            };
            solveButton.Click += SolveButton_Click;
            this.Controls.Add(solveButton);
        }

        private void InitializeBoard()
        {
            cells = new TextBox[GRID_SIZE, GRID_SIZE];
            originalPuzzle = new int[GRID_SIZE, GRID_SIZE];
            solvedPuzzle = new int[GRID_SIZE, GRID_SIZE];

            for (int row = 0; row < GRID_SIZE; row++)
            {
                for (int col = 0; col < GRID_SIZE; col++)
                {
                    cells[row, col] = new TextBox
                    {
                        Location = new Point(BOARD_PADDING + col * CELL_SIZE, BOARD_PADDING + row * CELL_SIZE),
                        Size = new Size(CELL_SIZE, CELL_SIZE),
                        Font = new Font("Arial", 18, FontStyle.Bold),
                        TextAlign = HorizontalAlignment.Center,
                        MaxLength = 1
                    };

                    // Add event handlers
                    cells[row, col].KeyPress += Cell_KeyPress;
                    cells[row, col].TextChanged += Cell_TextChanged;
                    cells[row, col].Tag = new Point(row, col);

                    // Add to form
                    this.Controls.Add(cells[row, col]);
                }
            }

            // Draw grid lines
            this.Paint += SudokuForm_Paint;
        }

        private void SudokuForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen blackPen = new Pen(Color.Black, 2))
            {
                // Draw grid borders
                for (int i = 0; i <= GRID_SIZE; i++)
                {
                    // Vertical lines
                    int lineWidth = (i % 3 == 0) ? 3 : 1;
                    e.Graphics.DrawLine(new Pen(Color.Black, lineWidth),
                        BOARD_PADDING + i * CELL_SIZE, BOARD_PADDING,
                        BOARD_PADDING + i * CELL_SIZE, BOARD_PADDING + GRID_SIZE * CELL_SIZE);

                    // Horizontal lines
                    e.Graphics.DrawLine(new Pen(Color.Black, lineWidth),
                        BOARD_PADDING, BOARD_PADDING + i * CELL_SIZE,
                        BOARD_PADDING + GRID_SIZE * CELL_SIZE, BOARD_PADDING + i * CELL_SIZE);
                }
            }
        }

        private void Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits 1-9 and control characters
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == '0')
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void Cell_TextChanged(object sender, EventArgs e)
        {
            TextBox cell = (TextBox)sender;
            Point position = (Point)cell.Tag;
            int row = position.X;
            int col = position.Y;

            // Skip if this is a fixed cell
            if (originalPuzzle[row, col] != 0)
            {
                return;
            }

            // Update background color based on validity
            if (string.IsNullOrEmpty(cell.Text))
            {
                cell.BackColor = Color.White;
            }
            else
            {
                int value;
                if (int.TryParse(cell.Text, out value))
                {
                    if (IsValidMove(row, col, value))
                    {
                        cell.BackColor = Color.White;
                    }
                    else
                    {
                        cell.BackColor = Color.LightPink;
                    }
                }
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            GenerateNewPuzzle();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (IsBoardFilled() && IsBoardCorrect())
            {
                MessageBox.Show("Congratulations! You solved the puzzle correctly!", "Sudoku",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (IsBoardFilled())
            {
                MessageBox.Show("The solution is incorrect. Please check your answers.", "Sudoku",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The board is not completely filled yet.", "Sudoku",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            DisplaySolution();
        }

        private void GenerateNewPuzzle()
        {
            // Clear the board
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    cells[r, c].Text = "";
                    cells[r, c].BackColor = Color.White;
                    cells[r, c].ReadOnly = false;
                    originalPuzzle[r, c] = 0;
                    solvedPuzzle[r, c] = 0;
                }
            }

            // Generate a solved puzzle
            GenerateSolvedPuzzle();

            // Make a copy of the solved puzzle
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    solvedPuzzle[r, c] = originalPuzzle[r, c];
                }
            }

            // Remove some numbers to create a puzzle
            CreatePuzzle();

            // Display the puzzle
            DisplayPuzzle();
        }

        private void GenerateSolvedPuzzle()
        {
            // Start with an empty board
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    originalPuzzle[r, c] = 0;
                }
            }

            // Solve the puzzle (generate a valid solution)
            SolveSudoku(originalPuzzle);
        }

        private bool SolveSudoku(int[,] board)
        {
            for (int row = 0; row < GRID_SIZE; row++)
            {
                for (int col = 0; col < GRID_SIZE; col++)
                {
                    if (board[row, col] == 0)
                    {
                        // Try placing numbers 1-9
                        List<int> numbers = Enumerable.Range(1, 9).ToList();
                        ShuffleList(numbers);

                        foreach (int num in numbers)
                        {
                            if (IsValidPlacement(board, row, col, num))
                            {
                                board[row, col] = num;

                                if (SolveSudoku(board))
                                {
                                    return true;
                                }

                                board[row, col] = 0; // Backtrack
                            }
                        }

                        return false; // No valid number found
                    }
                }
            }

            return true; // All cells filled
        }

        private void ShuffleList<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private bool IsValidPlacement(int[,] board, int row, int col, int num)
        {
            // Check row
            for (int c = 0; c < GRID_SIZE; c++)
            {
                if (board[row, c] == num)
                {
                    return false;
                }
            }

            // Check column
            for (int r = 0; r < GRID_SIZE; r++)
            {
                if (board[r, col] == num)
                {
                    return false;
                }
            }

            // Check 3x3 box
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;
            for (int r = boxRow; r < boxRow + 3; r++)
            {
                for (int c = boxCol; c < boxCol + 3; c++)
                {
                    if (board[r, c] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void CreatePuzzle()
        {
            // Number of cells to keep (difficulty level)
            int cellsToKeep = 30; // Medium difficulty

            // Create a list of all positions
            List<Point> positions = new List<Point>();
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    positions.Add(new Point(r, c));
                }
            }

            // Shuffle the positions
            ShuffleList(positions);

            // Remove numbers from the positions not in the keep list
            for (int i = cellsToKeep; i < positions.Count; i++)
            {
                Point p = positions[i];
                originalPuzzle[p.X, p.Y] = 0;
            }
        }

        private void DisplayPuzzle()
        {
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    if (originalPuzzle[r, c] != 0)
                    {
                        cells[r, c].Text = originalPuzzle[r, c].ToString();
                        cells[r, c].ReadOnly = true;
                        cells[r, c].BackColor = Color.LightGray;
                    }
                    else
                    {
                        cells[r, c].Text = "";
                        cells[r, c].ReadOnly = false;
                        cells[r, c].BackColor = Color.White;
                    }
                }
            }
        }

        private void DisplaySolution()
        {
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    cells[r, c].Text = solvedPuzzle[r, c].ToString();

                    if (originalPuzzle[r, c] == 0)
                    {
                        cells[r, c].BackColor = Color.LightGreen;
                        cells[r, c].ReadOnly = true;
                    }
                }
            }
        }

        private bool IsBoardFilled()
        {
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    if (string.IsNullOrEmpty(cells[r, c].Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsBoardCorrect()
        {
            for (int r = 0; r < GRID_SIZE; r++)
            {
                for (int c = 0; c < GRID_SIZE; c++)
                {
                    int value;
                    if (int.TryParse(cells[r, c].Text, out value))
                    {
                        if (value != solvedPuzzle[r, c])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsValidMove(int row, int col, int value)
        {
            // Check row
            for (int c = 0; c < GRID_SIZE; c++)
            {
                if (c != col)
                {
                    if (!string.IsNullOrEmpty(cells[row, c].Text) && cells[row, c].Text == value.ToString())
                    {
                        return false;
                    }
                }
            }

            // Check column
            for (int r = 0; r < GRID_SIZE; r++)
            {
                if (r != row)
                {
                    if (!string.IsNullOrEmpty(cells[r, col].Text) && cells[r, col].Text == value.ToString())
                    {
                        return false;
                    }
                }
            }

            // Check 3x3 box
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;
            for (int r = boxRow; r < boxRow + 3; r++)
            {
                for (int c = boxCol; c < boxCol + 3; c++)
                {
                    if (r != row || c != col)
                    {
                        if (!string.IsNullOrEmpty(cells[r, c].Text) && cells[r, c].Text == value.ToString())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SudokuForm());
        }
    }
}