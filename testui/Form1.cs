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
using Memory;

namespace testui
{
    public partial class Form1 : Form
    {
        Mem meme = new Mem();
        public Form1()
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                meme.WriteMemory("base+59F7F9","bytes","74 08");
            }
            else
            {
                meme.WriteMemory("base+59F7F9", "bytes", "75 08");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                meme.WriteMemory("base+70DC10", "bytes", "90 90 90");
            }
            else
            {
                meme.WriteMemory("base+70DC10", "bytes", "0F 28 FA");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                meme.WriteMemory("base+70CC47", "bytes", "75 5D");
            }
            else
            {
                meme.WriteMemory("base+70CC47", "bytes", "74 5D");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                meme.WriteMemory("base+58FC46", "bytes", "74 1C");
            }
            else
            {
                meme.WriteMemory("base+58FC46", "bytes", "75 1C");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                meme.WriteMemory("base+5ADB55", "bytes", "75 68");
            }
            else
            {
                meme.WriteMemory("base+5ADB55", "bytes", "74 68");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked == true)
            {
                meme.WriteMemory("base+6AC30B", "bytes", "75 1C");
            }
            else
            {
                meme.WriteMemory("base+6AC30B", "bytes", "74 1C");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked==true)
            {
                meme.WriteMemory("base+6B4602", "bytes", "0F 85 17 01 00 00");
            }
            else
            {
                meme.WriteMemory("base+6B4602","bytes", "0F 84 17 01 00 00");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                meme.WriteMemory("base+6FAAC5", "bytes", "75 0D");
            }
            else
            {
                meme.WriteMemory("base+6FAAC5", "bytes", "74 0D");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox9.Checked == true)
            {
                meme.WriteMemory("base+6A9B57", "bytes", "75 09");
            }
            else
            {
                meme.WriteMemory("base+6A9B57", "bytes", "74 09");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox10.Checked == true)
            {
                meme.WriteMemory("base+5A2A31", "bytes", "75 5F");
            }
            else
            {
                meme.WriteMemory("base+5A2A31", "bytes", "74 5F");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox11.Checked == true)
            {
                meme.WriteMemory("base+7094CF", "bytes", "90 90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+7094CF", "bytes", "E8 FC 82 A1 FF");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox12.Checked == true)
            {
                meme.WriteMemory("base+6A9AA4", "bytes", "74 0E");
            }
            else
            {
                meme.WriteMemory("base+6A9AA4", "bytes", "75 0E");
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox13.Checked == true)
            {
                meme.WriteMemory("base+6A8A81", "bytes", "90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+6A8A81", "bytes", "F3 0F 5C D1");
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox14.Checked == true)
            {
                meme.WriteMemory("base+71DC1B", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+71DC1B", "bytes", "0F 82 49 19 00 00");
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                meme.WriteMemory("base+70CC4F", "bytes", "74 05");
            }
            else
            {
                meme.WriteMemory("base+70CC4F", "bytes", "75 05");
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox17.Checked == true)
            {
                meme.WriteMemory("base+CAC9E0", "bytes", "90 90");
            }
            else
            {
                meme.WriteMemory("base+CAC9E0", "bytes", "4F 6E");
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox18.Checked == true)
            {
                meme.WriteMemory("base+6A8AED", "bytes", "75 26");
            }
            else
            {
                meme.WriteMemory("base+6A8AED", "bytes", "74 26");
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox19.Checked == true)
            {
                meme.WriteMemory("base+6A89F8", "bytes", "75 0D");
            }
            else
            {
                meme.WriteMemory("base+6A89F8", "bytes", "74 0D");
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                meme.WriteMemory("base+6A8A92", "bytes", "75 22");
            }
            else
            {
                meme.WriteMemory("base+6A8A92", "bytes", "74 22");
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                meme.WriteMemory("base+6AA673,", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+6AA673,", "bytes", "85 B8 00 00 00 49");
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox22.Checked == true)
            {
                meme.WriteMemory("base+6A9CA2", "bytes", "75 05");
            }
            else
            {
                meme.WriteMemory("base+6A9CA2", "bytes", "74 05");
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox23.Checked == true)
            {
                meme.WriteMemory("base+6A3EBF", "bytes", "90 90 90");
            }
            else
            {
                meme.WriteMemory("base+6A3EBF", "bytes", "48 8B D9");
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox24.Checked == true)
            {
                meme.WriteMemory("base+6A9AB2", "bytes", "74 03");
            }
            else
            {
                meme.WriteMemory("base+6A9AB2", "bytes", "75 03");
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox25.Checked == true)
            {
                meme.WriteMemory("base+70CC47", "bytes", "75 5D");
                meme.WriteMemory("base+70DC10", "bytes", "90 90 90");
                meme.WriteMemory("base+6FAAB5", "bytes", "90 90");
                meme.WriteMemory("base+CAC9E0", "bytes", "90 90");
            }
            else
            {
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
                meme.WriteMemory("base+19FDD9", "bytes", "90 90");
            }
            else
            {
                meme.WriteMemory("base+19FDD9", "bytes", "72 A7");
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox27.Checked == true)
            {
                meme.WriteMemory("base+6FAAB5","bytes", "90 90");
            }
            else
            {
                meme.WriteMemory("base+6FAAB5", "bytes", "75 0B");
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox28.Checked == true)
            {
                meme.WriteMemory("base+6FAA8A", "bytes", "90 90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+6FAA8A", "bytes", "83 7C 02 04 1B");
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                meme.WriteMemory("base+6FAAB5", "bytes", "74 0B");
            }
            else
            {
                meme.WriteMemory("base+6FAAB5", "bytes", "75 0B");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                meme.WriteMemory("base+6A8A94", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                meme.WriteMemory("base+6A8A94", "bytes", "F6 87 88 01 00 00 01");
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                meme.WriteMemory("base+5AE08F", "bytes", "0F 84 3C FE FF FF");
            }
            else
            {
                meme.WriteMemory("base+5AE08F", "bytes", "0F 85 3C FE FF FF");
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox31.Checked == true)
            {
                meme.WriteMemory("base+6ABC3A","bytes", "90 90");
            }
            else
            {
                meme.WriteMemory("base+6ABC3A", "bytes", "EB 03");
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox32.Checked == true)
            {
                meme.WriteMemory("base+6A8B35", "bytes", "75 29");
            }
            else
            {
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
            this.ResumeLayout();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            visualtab.Visible = false;
            panel3.Visible = true;
            Application.DoEvents();
            this.ResumeLayout();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 settings = new Form2();
            settings.Show();
        }
    }
}
