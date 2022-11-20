using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static exodus.arraylist;
using static testui.overlay;

namespace exodus
{
    public partial class arraylist : Form
    {
        public const string WINDOW_NAME = "Growtopia";

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, WINDOW_NAME);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        public static RECT rect;

        public struct RECT
        {
            public int left, top, right, bottom;
        }

       

        public arraylist()
        {
            InitializeComponent();
        }

        private void arraylist_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.TopMost = true;

            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x8000 | 0x20);

            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Left = rect.left;
            this.Top = rect.top;
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                GetWindowRect(handle, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
                this.Left = rect.left;
                this.Top = rect.top;
                Thread.Sleep(100);
            }
        }

        private void label18_Click(object sender, EventArgs e) // dont touch ! these make dragging work believe it or not
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
