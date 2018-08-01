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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SteamWebAPI.SetGlobalKey(Resources.api);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string method = comboBox1.Text;
            int count = (int)numericUpDown1.Value;
            List<string> ids = new List<string>();

            switch (method)
            {
                case "Word":
                    break;
                case "Letters":
                    break;
                case "Numbers":
                    break;
                default:
                    MessageBox.Show("Invalid method!");
                    return;
            }
            //var result = SteamWebAPI.General().ISteamUser().ResolveVanityURL("kneecocks").GetResponse();
        }
    }
    //class Student
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public double AvgGrade { get; set; }

    //    public void SayDespacito()
    //    {
    //        MessageBox.Show(this.Name + " says despacito");

    //    }
    //    public Student(string name, int age, double avggrade)
    //    {
    //        this.Name = name;
    //        this.Age = age;
    //        this.AvgGrade = avggrade;
    //    }
    //}
}
