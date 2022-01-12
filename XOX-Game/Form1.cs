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
            Write(button1);
            XOX();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Write(button2);
            XOX();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Write(button3);
            XOX();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Write(button4);
            XOX();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Write(button5);
            XOX();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Write(button6);
            XOX();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Write(button7);
            XOX();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Write(button8);
            XOX();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Write(button9);
            XOX();
        }
        private void Write(Button button)
        {
            button.Enabled = false;
            meter++;
            if (meter % 2 == 0)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
        }
        private void XOX()
        {
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
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
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
            //////////////////////////////////////////////////////////////////////////////////////////
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                end = true;
                winner = "X";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                end = true;
                winner = "O";
                if (end == true)
                {
                    MessageBox.Show($"{winner} win!");
                    this.Close();
                }
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
        }
    }
}
