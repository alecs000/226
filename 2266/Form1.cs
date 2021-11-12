using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2266
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        bool[] arrTFSix = {false, false, false, false, false, false, false};

        int numhowm2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Location.Y > 195 && !arrTFSix[6])
            {
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick1);
                timer.Tick -= new EventHandler(Timer_Tick6);
                timer.Interval = 1;
                timer.Start();
                numhowm2++;
                if (numhowm2 == 1)
                {
                    timer.Tick += new EventHandler(Timer_Tick2);
                }
            }
        }
        int numhowm3 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            

            if (pictureBox1.Location.Y < 93 && !arrTFSix[5])
            {
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Interval = 1;
                timer.Start();
                numhowm3++;
                if (numhowm3 == 1)
                {
                    timer.Tick += new EventHandler(Timer_Tick3);
                }
                
            }
        }
        int numhowm4 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
           
            if (pictureBox1.Location.Y > 93 && !arrTFSix[6] && !arrTFSix[1])
            {

                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick1);
                
                timer.Tick -= new EventHandler(Timer_Tick6);
                timer.Interval = 1;
                timer.Start();
                numhowm4++;
                if (numhowm4==1)
                {
                    timer.Tick += new EventHandler(Timer_Tick4);
                }
                    
                
            }
        }
        int numhowm5 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            
            

            if (pictureBox1.Location.Y > 0&& !arrTFSix[6]&&!arrTFSix[3] && !arrTFSix[1])
            {
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick1);
                timer.Tick -= new EventHandler(Timer_Tick6);
                timer.Interval = 1;
                timer.Start();
                numhowm5++;
                if (numhowm5 == 1)
                {
                    timer.Tick += new EventHandler(Timer_Tick5);
                }
            }
        }
        int numhowm1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 195 && !arrTFSix[5] && !arrTFSix[4])
            {
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Interval = 1;
                timer.Start();
                numhowm1++;
                if (numhowm1 == 1)
                {
                    timer.Tick += new EventHandler(Timer_Tick1);
                }
                
            }
        }
        int numhowm6 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 279&&!arrTFSix[5] && !arrTFSix[4] && !arrTFSix[2])
            {
                
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Interval = 1;
                timer.Start();
                numhowm6++;
                if (numhowm6 == 1)
                {
                    timer.Tick += new EventHandler(Timer_Tick6);
                }
            }
        }
        void Timer_Tick2(object Sender, EventArgs e)
        {
            
            bool bTF = false;
            for (int i = 1; i < arrTFSix.Length; i++)
            {
                if (arrTFSix[i]&& i!=2)
                {
                    bTF = true;
                    break;
                }
            }
            
            if (pictureBox1.Location.Y > 195 && !bTF)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                arrTFSix[2] = true;
            }
            if (pictureBox1.Location.Y == 195)
            {
                numhowm2 = 0;
                arrTFSix[2] = false;
                Thread.Sleep(2000);
            }
        }
        void Timer_Tick3(object Sender, EventArgs e)
        {
            bool bTF = false;
            for (int i = 1; i < arrTFSix.Length; i++)
            {
                if (arrTFSix[i] && i != 3)
                {
                    bTF = true;
                    break;
                }
            }
            if (pictureBox1.Location.Y < 93 && !bTF)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                arrTFSix[3] = true;
            }
            if (pictureBox1.Location.Y == 93)
            {
                numhowm3 = 0;
                arrTFSix[3] = false;
                Thread.Sleep(2000);
            }
           
        }
        void Timer_Tick1(object Sender, EventArgs e)
        {
            bool bTF = false;
            for (int i = 1; i < arrTFSix.Length; i++)
            {
                if (arrTFSix[i] && i != 1)
                {
                    bTF = true;
                    break;
                }
            }
            if (pictureBox1.Location.Y < 195 && !bTF)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                arrTFSix[1] = true;
            }
            if (pictureBox1.Location.Y == 195)
            {
                numhowm1 = 0;
                arrTFSix[1] = false;
                Thread.Sleep(2000);
            }
        }
        void Timer_Tick6(object Sender, EventArgs e)
        {
            bool bTF = false;
            for (int i = 1; i < arrTFSix.Length; i++)
            {
                if (arrTFSix[i] && i != 6)
                {
                    bTF = true;
                    break;
                }
            }
            if (pictureBox1.Location.Y < 279 && !bTF)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                arrTFSix[6] = true;
            }
            if (pictureBox1.Location.Y == 279)
            {
                numhowm6 = 0;
                arrTFSix[6] = false;
                Thread.Sleep(2000);
            }
            
        }
        void Timer_Tick4(object Sender, EventArgs e)
        {
            bool bTF = false;
            for (int i = 1; i < arrTFSix.Length; i++)
            {
                if (arrTFSix[i] && i != 4)
                {
                    bTF = true;
                    break;
                }
            }
            if (pictureBox1.Location.Y > 93&& !bTF)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                arrTFSix[4] = true;
            }
            if (pictureBox1.Location.Y == 93)
            {
                numhowm4 = 0;
                arrTFSix[4] = false;
                Thread.Sleep(2000);
            }
            
        }
        void Timer_Tick5(object Sender, EventArgs e)
        {
            bool bTF = false;
            for (int i = 1; i < arrTFSix.Length; i++)
            {
                if (arrTFSix[i] && i != 5)
                {
                    bTF = true;
                    break;
                }
            }
            if (pictureBox1.Location.Y > 0 && !bTF)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                arrTFSix[5] = true;
            }
            if (pictureBox1.Location.Y == 0)
            {
                numhowm5 = 0;
                arrTFSix[5] = false;
                Thread.Sleep(2000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
