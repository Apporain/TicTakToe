using TickTackToeClass;

namespace TicTackToeGui
{
    public partial class TickTackToeForm : Form
    {
        char currentPlayer = '0';
        Button lastClickedbutton = new Button();
        char[,] GameBoard;
        Button[,] ButtonBoard;

        public TickTackToeForm()
        {
            InitializeComponent();
            GameBoard = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            ButtonBoard = new Button[3, 3] { { btnGame00, btnGame01, btnGame02 }, { btnGame10, btnGame11, btnGame12 }, { btnGame20, btnGame21, btnGame22 } };
        }


        private void TickTackToeForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void changePlayer()
        {
            if (currentPlayer == 'X')
            {
                currentPlayer = '0';

            }
            else if (currentPlayer == '0')
            {
                currentPlayer = 'X';
            }
        }

        private char CycleButtonText(Button button)
        {
            if (button.Text == "X" || button.Text == "0")
            {
                return ' ';
            }
            else
            {
                return currentPlayer;
            }
        }

        private char CheckButtonCycleNeeded(bool sameButton, Button button)
        {
            char btnText;
            if (!sameButton)
            {

                btnText = CycleButtonText(button);
                return btnText;
            }
            else
            {
                changePlayer();
                btnText = CycleButtonText(button);
                return btnText;
            }
        }

        private bool CheckLastClickedButton(Button button)
        {
            if (button != lastClickedbutton)
            {
                lblCurrentPlayer.Text = currentPlayer.ToString();
                changePlayer();
                return false;
            }
            return true;
        }

        private void UpdateGameBoard(Button btn)
        {
            int indexone = Int32.Parse(btn.Name[7].ToString());
            int indextwo = Int32.Parse(btn.Name[8].ToString());
            GameBoard[indexone, indextwo] = btn.Text[0];
        }

        private char CheckForWinner(char[,] gameboard)
        {
            IGameWinnerService checkwinner = new GameWinnerService();
            return checkwinner.Validate(gameboard);
        }

        private void ButtonClick(object sender)
        {
            Button btn = (Button)sender;
            char winner;
            bool sameButton = CheckLastClickedButton(btn);
            btn.Text = CheckButtonCycleNeeded(sameButton, btn).ToString();
            UpdateGameBoard(btn);
            winner = CheckForWinner(GameBoard);
            if (winner != ' ')
            {
                lblCurrentPlayer.Text = winner.ToString();
                lblAnnouncement.Text = "Winner: ";
                WinConditionsMet();
            }

        }

        private void WinConditionsMet()
        {
            foreach (Button e in ButtonBoard) { e.Enabled = false; };
        }
        private void btnGame1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnGame4_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnGame5_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnGame6_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnGame7_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnGame8_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnGame9_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}