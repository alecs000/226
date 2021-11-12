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
        

        private void button2_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Location.Y > 195)
            {

                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick1);
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Interval = 1;
                timer.Start();
                bool bTF = false;
                for (int i = 1; i < arrTFSix.Length; i++)
                {
                    if (arrTFSix[i])
                    {
                        bTF = true;
                        break;
                    }
                }
                if (!bTF)
                {
                    timer.Tick += new EventHandler(Timer_Tick2);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (pictureBox1.Location.Y < 93)
            {
                
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Interval = 1;
                timer.Start();
                bool bTF = false;
                for (int i = 1; i < arrTFSix.Length; i++)
                {
                    if (arrTFSix[i])
                    {
                        bTF = true;
                        break;
                    }


                }
                if (!bTF)
                {
                    timer.Tick += new EventHandler(Timer_Tick3);
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (pictureBox1.Location.Y > 93)
            {
                
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Tick -= new EventHandler(Timer_Tick1);
                timer.Tick -= new EventHandler(Timer_Tick6);
                timer.Interval = 1;
                timer.Start();
                
                bool bTF = false;
                for (int i = 1; i < arrTFSix.Length; i++)
                {
                    if (arrTFSix[i])
                    {
                        bTF = true;
                        break;
                    }
                }
                if (!bTF)
                {
                    timer.Tick += new EventHandler(Timer_Tick4);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            

            if (pictureBox1.Location.Y > 0)
            {
               
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Tick -= new EventHandler(Timer_Tick1);
                timer.Tick -= new EventHandler(Timer_Tick6);
                timer.Interval = 1;
                timer.Start();
                bool bTF = false;
                for (int i = 1; i < arrTFSix.Length; i++)
                {
                    if (arrTFSix[i])
                    {
                        bTF = true;
                        break;
                    }


                }
                if (!bTF)
                {
                    timer.Tick += new EventHandler(Timer_Tick5);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 195)
            {
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Interval = 1;

                timer.Start();
                bool bTF = false;
                for (int i = 1; i < arrTFSix.Length; i++)
                {
                    if (arrTFSix[i])
                    {
                        bTF = true;
                        break;
                    }
                }
                if (!bTF)
                {
                    timer.Tick += new EventHandler(Timer_Tick1);
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 279)
            {
                
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick1);
                //timer.Tick -= new EventHandler(Timer_Tick);
                timer.Interval = 1;
                timer.Start();
                bool bTF = false;
                for (int i = 1; i < arrTFSix.Length; i++)
                {
                    if (arrTFSix[i])
                    {
                        bTF = true;
                        break;
                    }


                }
                if (!bTF)
                {
                    timer.Tick += new EventHandler(Timer_Tick6);
                }
            }
        }
        void Timer_Tick2(object Sender, EventArgs e)
        {
            
            if (pictureBox1.Location.Y > 195)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                arrTFSix[2] = true;
            }
            if (pictureBox1.Location.Y == 195)
            {
                arrTFSix[2] = false;
                Thread.Sleep(2000);
            }
        }
        void Timer_Tick3(object Sender, EventArgs e)
        {

            if (pictureBox1.Location.Y < 93)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                arrTFSix[3] = true;
            }
            if (pictureBox1.Location.Y == 93)
            {
                arrTFSix[3] = false;
                Thread.Sleep(2000);
            }
           
        }
        void Timer_Tick1(object Sender, EventArgs e)
        {
            
            if (pictureBox1.Location.Y < 195)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                arrTFSix[1] = true;
            }
            if (pictureBox1.Location.Y == 195)
            {
                arrTFSix[1] = false;
                Thread.Sleep(2000);
            }
        }
        void Timer_Tick6(object Sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 279)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                arrTFSix[6] = true;
            }
            if (pictureBox1.Location.Y == 279)
            {
                arrTFSix[6] = false;
                Thread.Sleep(2000);
            }
            
        }
        void Timer_Tick4(object Sender, EventArgs e)
        {if (pictureBox1.Location.Y > 93)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                arrTFSix[4] = true;
            }
            if (pictureBox1.Location.Y == 93)
            {
                arrTFSix[4] = false;
                Thread.Sleep(2000);
            }
            
        }
        void Timer_Tick5(object Sender, EventArgs e)
        {if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                arrTFSix[5] = true;
            }
            if (pictureBox1.Location.Y == 0)
            {
                arrTFSix[5] = false;
                Thread.Sleep(2000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
