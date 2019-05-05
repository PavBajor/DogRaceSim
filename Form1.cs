using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        
        int zmienna = 0;
        Dog[] dogs = new Dog[4];
        Guy[] guys = new Guy[3];
        public Form1()
        {
            InitializeComponent();



            dogs[0] = new Dog(0, 550, 0, pictureBox2);
            dogs[1] = new Dog(0, 550, 0, pictureBox3);
            dogs[2] = new Dog(0, 550, 0, pictureBox4);
            dogs[3] = new Dog(0, 550, 0, pictureBox5);
            
            
            guys[0] = new Guy("Joe", null, 100, radioButton1, label4);
            guys[1] = new Guy("Bob", null, 100, radioButton2, label5);
            guys[2] = new Guy("Al", null, 100, radioButton3, label6);

            label4.Text = guys[0]._name + " bets " + guys[0]._bet;
            label5.Text = guys[1]._name + " bets " + guys[1]._bet;
            label6.Text = guys[2]._name + " bets " + guys[2]._bet;

            for (int i = 0; i < 3; i++)
            {
                guys[i].UpdateLabels();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Joe";
            zmienna = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Bob";
            zmienna = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Al";
            zmienna = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (zmienna == 1)
            {
                guys[0].PlaceBet(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                guys[0].UpdateLabels();
                
            }
            if (zmienna == 2)
            {
                guys[1].PlaceBet(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                guys[1].UpdateLabels();
            }
            if (zmienna == 3)
            {
                guys[2].PlaceBet(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                guys[2].UpdateLabels();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (dogs[0].Run() == false && dogs[1].Run() == false && dogs[2].Run() == false && dogs[3].Run() == false)
            {
                for (int i = 0; i < 4; i++)
                {
                    dogs[i].Run();
                    Thread.Sleep(30);
                }
            } 

            if (dogs[0].Run())
            {
                MessageBox.Show("Dog #1 is winner");
                for (int i = 0; i < 3; i++)
                {
                    guys[i].Collect(1);
                    
                    guys[i].UpdateLabels();
                    
                }
            }
            else if (dogs[1].Run())
            {
                MessageBox.Show("Dog #2 is winner");
                for (int i = 0; i < 3; i++)
                {
                    guys[i].Collect(2);
                    
                    guys[i].UpdateLabels();
                    
                }
            }
            else if (dogs[2].Run())
            {
                MessageBox.Show("Dog #3 is winner");
                for (int i = 0; i < 3; i++)
                {
                    guys[i].Collect(3);
                    
                    guys[i].UpdateLabels();
                    
                }
            }
            else if (dogs[3].Run())
            {
                MessageBox.Show("Dog #4 is winner");
                for (int i = 0; i < 3; i++)
                {
                    guys[i].Collect(4);
                    
                    guys[i].UpdateLabels();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                guys[i].ClearBet();
                guys[i].UpdateLabels();
            }
            for (int i = 0; i < 4; i++)
            {
                dogs[i].TakeTheStartingPosition();
            }


        }
    }
}
