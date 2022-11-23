using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testui;

namespace exodus.Trainer
{
    public partial class console : Form
    {
        public console()
        {
            InitializeComponent();
        }

        Mem meme = new Mem();
        string time = DateTime.Now.ToString("h:mm:ss");
        
        private void console_Load(object sender, EventArgs e)
        {
            ConsoleRTB.AppendText(time + " | " + "Welcome to the Exodus Developer Console - here you may use console commands for debugging or viewing errors. You may also exit this page and nothing will happen.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textbox1.Text;
            textbox1.Text = "";
            void inputToConsole()
            {
                ConsoleRTB.AppendText("\r\n" + time + " | " + input);
            }

            inputToConsole();

            switch (input)
            {
                case "clear":
                    ConsoleRTB.ResetText();
                    break;
                case "help":
                    ConsoleRTB.AppendText("\r\n" + "clear | clears the console of text");
                    ConsoleRTB.AppendText("\r\n" + "help | show all commands");
                    ConsoleRTB.AppendText("\r\n" + "enable | enables the module specified");
                    ConsoleRTB.AppendText("\r\n" + "disable | disables the module specified");
                    ConsoleRTB.AppendText("\r\n" + "versionspoof | shows information about version spoofer (WIP)");
                    ConsoleRTB.AppendText("\r\n" + "info | show general information");
                    break;
                case "enable":
                    ConsoleRTB.AppendText("\r\n" + "please specify a module");                    
                    break;
                case "disable":                    
                    ConsoleRTB.AppendText("\r\n" + "please specify a module");
                    break;
                case "versionspoofer":
                    ConsoleRTB.AppendText("\r\n" + "the version spoofer (WIP) is based on HirakoShiniji's Github open-source Growtopia version spoofer. The spoofer works with HTTP and memory.");
                    break;
                case "enable antibounce":
                    meme.WriteMemory("base+70DC10", "bytes", "90 90 90");
                    ConsoleRTB.AppendText("\r\n" + "antibounce is now enabled");
                    break;
                case "disable antibounce":
                    meme.WriteMemory("base+70DC10", "bytes", "0F 28 FA");
                    ConsoleRTB.AppendText("\r\n" + "antibounce is now disabled");
                    break;

            }

        }

        
        






    private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
