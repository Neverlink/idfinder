using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using PortableSteam;
using System.IO;
using idfinder.Properties;
namespace idfinder
{
    public partial class MainForm : Form
    {
        public static MainForm mf = new MainForm();
        public MainForm()
        {
            InitializeComponent();
            mf = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SteamWebAPI.SetGlobalKey(Resources.api);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string method = comboBox1.Text;
            int count = (int)numericUpDown1.Value;

            switch (method)
            {
                case "Word":
                    Utility.FindWordIds(count);
                    break;
                case "Letters":
                    Utility.FindLetterIds(count);
                    break;
                case "Numbers":
                    Utility.FindNumberIds(count);
                    break;
                default:
                    MessageBox.Show("Invalid method!");
                    return;
            }
            //var result = SteamWebAPI.General().ISteamUser().ResolveVanityURL("kneecocks").GetResponse();
        }
    }
}
