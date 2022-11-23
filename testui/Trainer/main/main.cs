using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Memory;
using exodus;
using System.Linq.Expressions;
using exodus.Trainer;

namespace testui
{
    public partial class main : Form
    {
        
        Mem meme = new Mem();
        public main()
        {
            InitializeComponent();
        }
        
        private bool mouseDown;
        private Point lastLocation;

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            meme.OpenProcess("Growtopia.exe");

            if (meme.OpenProcess("Growtopia.exe"))
            {
                label3.Text = "attached: yes";
            }
            else
            {
                label3.Text = "attached: no";
            }
        }

        arraylist arraylist = new arraylist();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
                if (checkBox1.Checked == true)
                {
                    meme.WriteMemory("base+59F7F9", "bytes", "74 08");


                }
                else
                {
                    meme.WriteMemory("base+59F7F9", "bytes", "75 08");
                }
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                arraylist.label3.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+70DC10", "bytes", "90 90 90");
            }
            else
            {
                arraylist.label3.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+70DC10", "bytes", "0F 28 FA");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                arraylist.label5.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+70CC47", "bytes", "75 5D");
            }
            else
            {
                arraylist.label5.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+70CC47", "bytes", "74 5D");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                arraylist.label4.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+58FC46", "bytes", "74 1C");
            }
            else
            {
                arraylist.label4.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+58FC46", "bytes", "75 1C");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                arraylist.label9.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+5ADB55", "bytes", "75 68");
            }
            else
            {
                arraylist.label9.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+5ADB55", "bytes", "74 68");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked == true)
            {
                arraylist.label8.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6AC30B", "bytes", "75 1C");
            }
            else
            {
                arraylist.label8.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6AC30B", "bytes", "74 1C");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked==true)
            {
                arraylist.label6.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6B4602", "bytes", "0F 85 17 01 00 00");
            }
            else
            {
                arraylist.label6.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6B4602","bytes", "0F 84 17 01 00 00");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                arraylist.label7.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6FAAC5", "bytes", "75 0D");
            }
            else
            {
                arraylist.label7.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6FAAC5", "bytes", "74 0D");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox9.Checked == true)
            {
                arraylist.label17.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A9B57", "bytes", "75 09");
            }
            else
            { 
                arraylist.label17.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A9B57", "bytes", "74 09");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox10.Checked == true)
            {
                arraylist.label19.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+5A2A31", "bytes", "75 5F");
            }
            else
            {
                arraylist.label19.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+5A2A31", "bytes", "74 5F");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox11.Checked == true)
            {
                arraylist.label20.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+7094CF", "bytes", "90 90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+7094CF", "bytes", "E8 FC 82 A1 FF");
                arraylist.label20.Visible = false;
                Application.DoEvents();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox12.Checked == true)
            {
                arraylist.label18.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A9AA4", "bytes", "74 0E");
            }
            else
            {
                arraylist.label18.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A9AA4", "bytes", "75 0E");
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox13.Checked == true)
            {
                arraylist.label15.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A8A81", "bytes", "90 90 90 90");
            }
            else
            {
                arraylist.label15.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A8A81", "bytes", "F3 0F 5C D1");
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox14.Checked == true)
            {
                arraylist.label10.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+71DC1B", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                arraylist.label10.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+71DC1B", "bytes", "0F 82 49 19 00 00");
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                arraylist.label11.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+70CC4F", "bytes", "74 05");
            }
            else
            {
                arraylist.label11.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+70CC4F", "bytes", "75 05");
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox17.Checked == true)
            {
                arraylist.label24.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+CAC9E0", "bytes", "90 90");
            }
            else
            {
                arraylist.label24.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+CAC9E0", "bytes", "4F 6E");
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox18.Checked == true)
            {
                arraylist.label28.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A8AED", "bytes", "75 26");
            }
            else
            {
                arraylist.label28.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A8AED", "bytes", "74 26");
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox19.Checked == true)
            {
                arraylist.label23.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A89F8", "bytes", "75 0D");
            }
            else
            {
                arraylist.label23.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A89F8", "bytes", "74 0D");
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                arraylist.label25.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A8A92", "bytes", "75 22");
            }
            else
            {
                arraylist.label25.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A8A92", "bytes", "74 22");
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                arraylist.label26.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6AA673,","bytes","90 90 90 90 90 90");
            }
            else
            {
                arraylist.label26.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6AA673,","bytes","85 B8 00 00 00 49");
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox22.Checked == true)
            {
                arraylist.label27.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A9CA2", "bytes", "75 05");
            }
            else
            {
                arraylist.label27.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A9CA2", "bytes", "74 05");
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox23.Checked == true)
            {
                arraylist.label32.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A3EBF", "bytes", "90 90 90");
            }
            else
            {
                arraylist.label32.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A3EBF", "bytes", "48 8B D9");
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox24.Checked == true)
            {
                arraylist.label29.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A9AB2", "bytes", "74 03");
            }
            else
            {
                arraylist.label29.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A9AB2", "bytes", "75 03");
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox25.Checked == true)
            {
                arraylist.label2.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+70CC47", "bytes", "75 5D");
                meme.WriteMemory("base+70DC10", "bytes", "90 90 90");
                meme.WriteMemory("base+6FAAB5", "bytes", "90 90");
                meme.WriteMemory("base+CAC9E0", "bytes", "90 90");
            }
            else
            {
                arraylist.label2.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+70CC47", "bytes", "74 5D");
                meme.WriteMemory("base+70DC10", "bytes", "0F 28 FA");
                meme.WriteMemory("base+6FAAB5", "bytes", "75 0B");
                meme.WriteMemory("base+CAC9E0", "bytes", "4F 6E");
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox26.Checked == true)
            {
                arraylist.label16.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+19FDD9", "bytes", "90 90");
            }
            else
            {
                arraylist.label16.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+19FDD9", "bytes", "72 A7");
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox27.Checked == true)
            {
                arraylist.label22.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6FAAB5","bytes", "90 90");
            }
            else
            {
                arraylist.label22.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6FAAB5", "bytes", "75 0B");
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox28.Checked == true)
            {
                arraylist.label31.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6FAA8A", "bytes", "90 90 90 90 90");
            }
            else
            {
                arraylist.label31.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6FAA8A", "bytes", "83 7C 02 04 1B");
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                arraylist.label14.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6FAAB5", "bytes", "74 0B");
            }
            else
            {
                arraylist.label14.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6FAAB5", "bytes", "75 0B");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                arraylist.label13.Visible = true;
                Application.DoEvents();
                meme.WriteMemory("base+6A8A94", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                arraylist.label13.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A8A94", "bytes", "F6 87 88 01 00 00 01");
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                arraylist.label21.Show();
                Application.DoEvents();
                meme.WriteMemory("base+5AE08F", "bytes", "0F 84 3C FE FF FF");
            }
            else
            {
                arraylist.label21.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+5AE08F", "bytes", "0F 85 3C FE FF FF");
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox31.Checked == true)
            {
                arraylist.label35.Show();
                Application.DoEvents();
                meme.WriteMemory("base+6ABC3A","bytes", "90 90");
            }
            else
            {
                arraylist.label35.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6ABC3A", "bytes", "EB 03");
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox32.Checked == true)
            {
                arraylist.label12.Show();
                Application.DoEvents();
                meme.WriteMemory("base+6A8B35", "bytes", "75 29");
            }
            else
            {
                arraylist.label12.Visible = false;
                Application.DoEvents();
                meme.WriteMemory("base+6A8B35", "bytes", "74 29");
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                meme.WriteMemory("base+69C6B0", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+69C6B0", "bytes", "48 8D 15 11 08 61 00");
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox34.Checked == true)
            {
                meme.WriteMemory("base+7213CB", "bytes", "0F 85 82 00 00 00");
            }
            else
            {
                meme.WriteMemory("base+7213CB", "bytes", "0F 84 82 00 00 00");
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox35.Checked == true)
            {
                meme.WriteMemory("base+121263", "bytes", "0F 85 9E 01 00 00");
            }
            else
            {
                meme.WriteMemory("base+121263", "bytes", "0F 84 9E 01 00 00");
            }
            
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                meme.WriteMemory("base+2370F9", "bytes", "75 6A");
            }
            else
            {
                meme.WriteMemory("base+2370F9", "bytes", "74 6A");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            visualtab.Visible = true;
            panel3.Visible = false;
            spammerpage.Visible = false;
            this.ResumeLayout();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            visualtab.Visible = false;
            panel3.Visible = true;
            spammerpage.Visible = false;
            Application.DoEvents();
            this.ResumeLayout();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            visualtab.Visible = false;
            panel3.Visible = false;
            spammerpage.Visible = true;
            Application.DoEvents();
            this.ResumeLayout();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(textBox2.Text);
            Thread.Sleep(2000);
            timer1.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            timer1.Stop();
        }
    }
}
