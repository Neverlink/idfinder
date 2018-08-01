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
using System.Diagnostics;

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
            totalIds.Value = 0;
            switch (method)
            {
                case "Words":
                    Utility.FindWordIds();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Made by neverlink - https://neverlink.tk. Want to visit my site?", "About", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("https://neverlink.tk");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Words")
            {
                numericUpDown1.Enabled = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
            }
        }
    }
}
