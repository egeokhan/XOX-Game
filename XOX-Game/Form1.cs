using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_Game
{
    public partial class Form1 : Form
    {
        int meter = 1;
        bool end = false;
        string winner;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }
            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        } 
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }

            /////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
        }
    }
}
