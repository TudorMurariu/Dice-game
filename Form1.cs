using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbut
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        int RandomInt(int min,int n)
        {       
            n = rand.Next(min,n);
            return n;
        }
        private void ROLL_Click(object sender, EventArgs e)
        {
            int dice1 = RandomInt(0,6);
            int dice2 = RandomInt(0,6);
            //this.textBox1.Text = dice1.ToString() + dice2.ToString();
            switch (dice1)
            {
                case 1:
                    this.Dice1.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    this.Dice1.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    this.Dice1.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    this.Dice1.Image = Properties.Resources.Dice;
                    break;
                case 5:
                    this.Dice1.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    this.Dice1.Image = Properties.Resources.Dice6;
                    break;
            }

            switch (dice2)
            {
                case 1:
                    this.Dice2.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    this.Dice2.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    this.Dice2.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    this.Dice2.Image = Properties.Resources.Dice;
                    break;
                case 5:
                    this.Dice2.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    this.Dice2.Image = Properties.Resources.Dice6;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
