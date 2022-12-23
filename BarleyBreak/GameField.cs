using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarleyBreak
{
    public partial class GameField : Form
    {
        public GameField()
        {
            InitializeComponent();

            MessageBox.Show("Нажмите S или M что бы перемешать поле.\r\n" +
                "После перемешивания запустится таймер, который покажет сколько вы играли.\r\n\r\n" +
                "Обратите внимание выигрышная комбинация - пустая клетка правый нижний угол.\r\n\r\n", "Как ирать ?");
        }


        readonly string[] randomNums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "" }; // Массив возможных значений кнопки
        int time;   // Переменная для счета времени


        // Обработки нажатия угловых кнопок
        #region Угловые кнопки
        private void ButtonСorner1_Click(object sender, EventArgs e)
        {
            IsWin();    // Проверка на выигрыш
            if ((sender as Button).Text == "" || (buttonSide1.Text != "" && buttonSide8.Text != ""))    // Проверка - возможно ли  кнопку
                return;

            if (buttonSide1.Text == "")
            {
                buttonSide1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }   // Проверка - можно ли "передвинуть" кнопук на место кнопки buttonSide1
            else if (buttonSide8.Text == "")
            {
                buttonSide8.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }   // Проверка - можно ли "передвинуть" кнопук на место кнопки buttonSide8
        }
        private void ButtonСorner2_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide3.Text != "" && buttonSide2.Text != ""))
                return;

            if (buttonSide3.Text == "")
            {
                buttonSide3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide2.Text == "")
            {
                buttonSide2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonCorner3_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide7.Text != "" && buttonSide6.Text != ""))
                return;

            if (buttonSide7.Text == "")
            {
                buttonSide7.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide6.Text == "")
            {
                buttonSide6.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonCorner4_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide4.Text != "" && buttonSide5.Text != ""))
                return;

            if (buttonSide4.Text == "")
            {
                buttonSide4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide5.Text == "")
            {
                buttonSide5.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        #endregion

        // Обработки нажатия боковых кнопок
        #region Боковые кнопки
        private void ButtonSide1_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide2.Text != "" && buttonMiddle1.Text != "" && buttonCorner1.Text != ""))
                return;

            if (buttonSide2.Text == "")
            {
                buttonSide2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle1.Text == "")
            {
                buttonMiddle1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonCorner1.Text == "")
            {
                buttonCorner1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonSide2_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonCorner2.Text != "" && buttonMiddle2.Text != "" && buttonSide1.Text != ""))
                return;

            if (buttonCorner2.Text == "")
            {
                buttonCorner2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle2.Text == "")
            {
                buttonMiddle2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide1.Text == "")
            {
                buttonSide1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonSide3_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonCorner2.Text != "" && buttonSide4.Text != "" && buttonMiddle2.Text != ""))
                return;

            if (buttonCorner2.Text == "")
            {
                buttonCorner2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide4.Text == "")
            {
                buttonSide4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle2.Text == "")
            {
                buttonMiddle2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonSide4_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide3.Text != "" && buttonCorner3.Text != "" && buttonMiddle3.Text != ""))
                return;

            if (buttonSide3.Text == "")
            {
                buttonSide3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonCorner3.Text == "")
            {
                buttonCorner3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle3.Text == "")
            {
                buttonMiddle3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonSide5_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonMiddle3.Text != "" && buttonCorner3.Text != "" && buttonSide6.Text != ""))
                return;

            if (buttonMiddle3.Text == "")
            {
                buttonMiddle3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonCorner3.Text == "")
            {
                buttonCorner3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide6.Text == "")
            {
                buttonSide6.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonSide6_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonMiddle4.Text != "" && buttonSide5.Text != "" && buttonCorner4.Text != ""))
                return;

            if (buttonMiddle4.Text == "")
            {
                buttonMiddle4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide5.Text == "")
            {
                buttonSide5.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonCorner4.Text == "")
            {
                buttonCorner4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonSide7_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide8.Text != "" && buttonMiddle4.Text != "" && buttonCorner4.Text != ""))
                return;

            if (buttonSide8.Text == "")
            {
                buttonSide8.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle4.Text == "")
            {
                buttonMiddle4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonCorner4.Text == "")
            {
                buttonCorner4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonSide8_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonCorner1.Text != "" && buttonMiddle1.Text != "" && buttonSide7.Text != ""))
                return;

            if (buttonCorner1.Text == "")
            {
                buttonCorner1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle1.Text == "")
            {
                buttonMiddle1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide7.Text == "")
            {
                buttonSide7.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        #endregion

        // Обработки нажатия централных кнопок
        #region Серединные кнопки
        private void ButtonMiddle1_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide1.Text != "" && buttonMiddle2.Text != "" && buttonMiddle4.Text != "" && buttonSide8.Text != ""))
                return;

            if (buttonSide1.Text == "")
            {
                buttonSide1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle2.Text == "")
            {
                buttonMiddle2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle4.Text == "")
            {
                buttonMiddle4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide8.Text == "")
            {
                buttonSide8.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonMiddle2_Click(object sender, EventArgs e)
        {
            IsWin();
            if ((sender as Button).Text == "" || (buttonSide2.Text != "" && buttonSide3.Text != "" && buttonMiddle3.Text != "" && buttonMiddle1.Text != ""))
                return;

            if (buttonSide2.Text == "")
            {
                buttonSide2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide3.Text == "")
            {
                buttonSide3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle3.Text == "")
            {
                buttonMiddle3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle1.Text == "")
            {
                buttonMiddle1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonMiddle3_Click(object sender, EventArgs e)
        {
            IsWin();
            if (buttonMiddle3.Text == "" || (buttonMiddle2.Text != "" && buttonSide4.Text != "" && buttonSide5.Text != "" && buttonMiddle4.Text != ""))
                return;

            if (buttonMiddle2.Text == "")
            {
                buttonMiddle2.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide4.Text == "")
            {
                buttonSide4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide5.Text == "")
            {
                buttonSide5.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle4.Text == "")
            {
                buttonMiddle4.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        private void ButtonMiddle4_Click(object sender, EventArgs e)
        {
            IsWin();
            if (buttonMiddle4.Text == "" || (buttonMiddle1.Text != "" && buttonMiddle3.Text != "" && buttonSide6.Text != "" && buttonSide7.Text != ""))
                return;

            if (buttonMiddle1.Text == "")
            {
                buttonMiddle1.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonMiddle3.Text == "")
            {
                buttonMiddle3.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide6.Text == "")
            {
                buttonSide6.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
            else if (buttonSide7.Text == "")
            {
                buttonSide7.Text = (sender as Button).Text;
                (sender as Button).Text = "";
            }
        }
        #endregion


        async private void GameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M || e.KeyCode == Keys.S)
            {
                if (time >= 60)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите начать сначала ?", "Внимане",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                    if (dialogResult == DialogResult.Yes)
                    {
                        timer.Enabled = false;
                        time = 0;
                    }
                    return;
                }
                else
                {
                    timer.Enabled = false;
                    time = 0;
                }

                for (byte i = 0; i < 10; i++, await Task.Delay(12))
                {
                    randomNums.ShuffleInProcess();
                    ShuffleShow();

                    timer.Enabled = true;
                }
            }
        }   // Обработки нажатия кнопок (S и M)

        private void ShuffleShow()
        {
            buttonCorner1.Text = randomNums[0];
            buttonCorner2.Text = randomNums[1];
            buttonCorner4.Text = randomNums[2];
            buttonCorner3.Text = randomNums[3];

            buttonSide1.Text = randomNums[4];
            buttonSide2.Text = randomNums[5];
            buttonSide3.Text = randomNums[6];
            buttonSide4.Text = randomNums[7];
            buttonSide5.Text = randomNums[8];
            buttonSide6.Text = randomNums[9];
            buttonSide7.Text = randomNums[10];
            buttonSide8.Text = randomNums[11];

            buttonMiddle1.Text = randomNums[12];
            buttonMiddle2.Text = randomNums[13];
            buttonMiddle3.Text = randomNums[14];
            buttonMiddle4.Text = randomNums[15];
        }   // Показать текущий прогресс перемешивания
        private void IsWin()
        {
            if (buttonCorner1.Text == "1" && buttonCorner2.Text == "4" && buttonCorner3.Text == "" && buttonCorner4.Text == "13" && buttonSide1.Text == "2" && buttonSide2.Text == "3" && buttonSide3.Text == "8" && buttonSide4.Text == "12" && buttonSide5.Text == "15" && buttonSide6.Text == "14" && buttonSide7.Text == "9" && buttonSide8.Text == "5" & buttonMiddle1.Text == "6" && buttonMiddle2.Text == "7" && buttonMiddle3.Text == "11" && buttonMiddle4.Text == "10")
            {
                timer.Enabled = false;

                int hours, minutes, seconds;

                hours = time / 60 / 60;
                minutes = time / 60;
                seconds = time - minutes * 60;

                MessageBox.Show($"Вы решали {hours}:{minutes}:{seconds}.", "Ура");

                time = 0;
                return;
            }
        }   // Проверка на выигрыш

        private void Timer_Tick(object sender, EventArgs e) => time += 1; // Таймер
    }
}