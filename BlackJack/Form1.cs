using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        int o1_total = 0, o2_total = 0;
        bool o1_statu = true, o2_statu = true;

        int[] o1_cards = new int[21];
        int[] o2_cards = new int[21];

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1 = random.Next(1, 11);
            Lblnumber1.Text = number1.ToString();
            o1_total += number1;
            Lblresult1.Text = o1_total.ToString();
            if (o1_total > 21)
            {
                Standbutton1.Enabled = false;
                Hitbutton1.Enabled = false;
                lblfinal1.Text = Lblresult1.Text;
            }
            if (o1_total < 21)
            {
                Standbutton2.Enabled = false;
                Hitbutton2.Enabled = false;
            }


            while (o1_total <= 21)
            {
                Lblreceived1.AppendText(number1.ToString()+ ", ");
                break;
            }
        }

        int blackjack = 21;

        private void button3_Click(object sender, EventArgs e)
        {
            if(o1_total <= 21&& o2_total >21)
            {
                MessageBox.Show("P1 Won");
            }
            if(o1_total > 21 && o2_total <= 21)
            {
                MessageBox.Show("P2 Won");
            }
            if(o1_total > 21 && o2_total > 21)
            {
                MessageBox.Show("House Wins");
            }
            if(o1_total>21 && o2_total<=21)
            {
                 MessageBox.Show("P2 Won");
            }
            if(o2_total>21 && o1_total<=21)
            {
                MessageBox.Show("P1 Won");
            }
            if(o1_total==o2_total && o1_total<21 && o2_total<21)
            {
                MessageBox.Show("Draw");
            }
            if (o1_total == blackjack && o2_total != blackjack)
            {
                MessageBox.Show("P1 Made Blackjack");
            }
            else if (o1_total != blackjack && o2_total == blackjack)
            {
                MessageBox.Show("P2 Made Blackjack");
            }
            
            if(o1_statu == true && o2_statu == true && o1_total< blackjack && o2_total<blackjack)
            {
                if (blackjack - o1_total < blackjack - o2_total)
                {
                    MessageBox.Show("P1 Won");
                }
                else if (blackjack - o1_total > blackjack - o2_total)
                {
                    MessageBox.Show("P2 Won");
                }
            }
            else if (o1_statu == true && o2_statu == false)
            {
                MessageBox.Show("P1 Won");
            }
            else if (o1_statu == false && o2_statu == true)
            {
                MessageBox.Show("P2 Won");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number2 = random.Next(1, 11);
            Lblnumber2.Text = number2.ToString();
            o2_total += number2;
            Lblresult2.Text = o2_total.ToString();
            Lblreceived2.AppendText(number2.ToString() + ", ");
            if (o2_total > 21)
            {
                Hitbutton2.Enabled = false;
                Standbutton2.Enabled = false;
                lblfinal2.Text = Lblresult2.Text;
            }
            if(o2_total < 21 && o1_total < 21)
            {
                Hitbutton1.Enabled = false;
                Standbutton1.Enabled = false;
            }
        }
       private void buttonkal1_Click_1(object sender, EventArgs e)
        {
            Hitbutton1.Enabled = false;
            lblfinal1.Text = Lblresult1.Text;
            Standbutton1.Enabled = false;
            Standbutton2.Enabled =true;
            Hitbutton2.Enabled=true;

            
        }
        private void buttonkal2_Click_1(object sender, EventArgs e)
        {
            lblfinal2.Text = Lblresult2.Text;
            Standbutton2.Enabled = false;
            Hitbutton2.Enabled=false;
            Hitbutton1.Enabled = true;
            Standbutton1.Enabled = true;
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
        

            Standbutton1.Enabled=true;
            Standbutton2.Enabled=true;
            Hitbutton1.Enabled=true;
            Hitbutton2.Enabled=true;
            Lblnumber1.Text = "";
            Lblnumber2.Text = "";
            Lblresult1.Text = "";
            Lblresult2.Text = "";
            Lblreceived1.Text = "";
            Lblreceived2.Text = "";
            lblfinal1.Text = "";
            lblfinal2.Text = "";
            o1_total= 0;                
            o2_total= 0;
        }

        private void buttonkal2_Click(object sender, EventArgs e)
        {
            lblfinal2.Text = o2_total.ToString();
            if (o2_total > 21)
            {
                MessageBox.Show("P2 Was Eliminated");
                o2_statu = false;
            }
        }
        private void buttonkal1_Click(object sender, EventArgs e)
        {
            lblfinal1.Text = o1_total.ToString();
            if (o1_total > 21) {
                MessageBox.Show("P1 Was Eliminated");
                o1_statu = false;
            }
        }
    }
}