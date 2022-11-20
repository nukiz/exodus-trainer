using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using System.Windows.Forms;
using System.Security.Cryptography;
using exodus;
using exodus.Trainer.msg;
using System.IO;
using System.Linq.Expressions;

namespace testui
{
    public partial class settings : Form
    {
        Mem meme = new Mem();
        public settings()
        {
            InitializeComponent();
        }       
        private void label2_Click(object sender, EventArgs e)
        {

        }        
        overlay overlay = new overlay();
        attacherror aerror = new attacherror();
        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                if (meme.OpenProcess("Growtopia"))
                {
                    overlay.Show();
                    overlay.TopMost = true;
                }
                else
                {
                    aerror.Show();
                    checkBox32.Checked = false;
                }                
            }
            else
            {
                overlay.Hide();
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        arraylist arraylist = new arraylist();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (meme.OpenProcess("Growtopia"))
                {
                    arraylist.Show();
                }
                else
                {
                    aerror.Show();
                    checkBox1.Checked = false;
                }
            }
            else
            {
                arraylist.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label3.Hide();
            }
            else
            {
                label3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "config"); // this is how we write a file for the config which will be saved

            if (checkBox2.Checked == true)
            {
                sw.WriteLine("autoantiban:true");
                sw.Close();
            }
            else
            {
                sw.WriteLine("autoantiban:false");
                sw.Close();
            }
            if (checkBox4.Checked == true)
            {
                sw.WriteLine("autoattach:true");
                sw.Close();
            }
            else
            {
                sw.WriteLine("autoattach:false");
                sw.Close();
                
            }
            
            
        }
    }
}
