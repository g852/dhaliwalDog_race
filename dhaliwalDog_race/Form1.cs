using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhaliwalDog_race
{
    public partial class Form1 : Form
    {
        // global variable 
        int rb1 = 180, rb2 = 180, rb3 = 180;
        greyHound instance_Object = new greyHound();

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //calling the method of the move to move the dog from one location to another 
            instance_Object.move(pb1, instance_Object.genNo());
            instance_Object.move(pb2, instance_Object.genNo());
            instance_Object.move(pb3, instance_Object.genNo());
            instance_Object.move(pb4, instance_Object.genNo());

            // calling the method of the winner to find the winner dog of the game and check the winner by passing the argument 
            if (instance_Object.winner(pb1,1)>0) {
                timer1.Stop();
                MessageBox.Show("dog 1 is the winner");
                reset(1);
                btnRace.Enabled = false;
                pb1.Left = 0; pb2.Left = 0; pb3.Left = 0; pb4.Left = 0;
            }
            if (instance_Object.winner(pb2, 2) > 0)
            {
                timer1.Stop();
                MessageBox.Show("dog 2 is the winner");
                reset(2);
                btnRace.Enabled = false;
                pb1.Left = 0; pb2.Left = 0; pb3.Left = 0; pb4.Left = 0;
            }

            if (instance_Object.winner(pb3, 3) > 0)
            {
                timer1.Stop();
                MessageBox.Show("dog 3 is the winner");
                reset(3);
                btnRace.Enabled = false;
                pb1.Left = 0; pb2.Left = 0; pb3.Left = 0; pb4.Left = 0;
            }
            if (instance_Object.winner(pb4, 4) > 0)
            {
                timer1.Stop();
                MessageBox.Show("dog 4 is the winner");
                reset(4);
                btnRace.Enabled = false;
                pb1.Left = 0; pb2.Left = 0; pb3.Left = 0; pb4.Left = 0;
            }

        }
        //reset the game after declaring the result of the game
        public void reset(int winner) {
            
            //if player one set the bet then reset his account balance
            if (label2.Text.Substring(0, label2.Text.IndexOf(" ")).Equals("Dog")) {
                String[] data = label2.Text.Split(' ');
               rb1=instance_Object.Amountset(Convert.ToInt32(data[1]),rb1,Convert.ToInt32(data[3]),winner);
                label2.Text = "Pinder has " + rb1 + " dollar";
               
            }
            //if player 2nd set the bet then reset his account balance
            if (label3.Text.Substring(0, label3.Text.IndexOf(" ")).Equals("Dog"))
            {
                String[] data = label3.Text.Split(' ');
                rb2=instance_Object.Amountset(Convert.ToInt32(data[1]), rb2, Convert.ToInt32(data[3]), winner);
                label3.Text = "Gurpreet has " + rb2 + " dollar";
               
            }
            //if player 3rd set the bet then reset his account balance
            if (label4.Text.Substring(0, label4.Text.IndexOf(" ")).Equals("Dog"))
            {
                String[] data = label4.Text.Split(' ');
                rb3=instance_Object.Amountset(Convert.ToInt32(data[1]), rb3, Convert.ToInt32(data[3]), winner);
                label4.Text = "Harnoor has " + rb3 + " dollar";
               
            }


        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            //start the timer to start the race 
            timer1.Start();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && amt.Value <= rb1) {
                label2.Text = "Dog " + dog.Value + " Amount " + amt.Value;
                btnRace.Enabled = true;
            } else if (radioButton2.Checked == true && amt.Value <= rb2) {
                label3.Text = "Dog " + dog.Value + " Amount " + amt.Value;
                btnRace.Enabled = true;
            }
            else if (radioButton3.Checked == true && amt.Value <= rb3)
            {
                label4.Text = "Dog " + dog.Value + " Amount " + amt.Value;
                btnRace.Enabled = true;
            }

        }
    }
}
