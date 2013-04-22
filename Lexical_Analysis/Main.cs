using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lexical_Analysis
{
    public partial class Main : Form
    {
        public static Dictionary<string, int> KeyWords = new Dictionary<string, int>();

        public Main()
        {
            InitializeComponent();
            initKeyWords(); 
        }
        private void initKeyWords()
        {
            KeyWords.Add("break", 1);
            KeyWords.Add("case", 2);
            KeyWords.Add("continue", 3);
            KeyWords.Add("default", 4);
            KeyWords.Add("do", 5);
            KeyWords.Add("else", 6);
            KeyWords.Add("for", 7);
            KeyWords.Add("if", 8);
            KeyWords.Add("return", 9);
            KeyWords.Add("switch", 10);
            KeyWords.Add("int", 11);
            KeyWords.Add("void", 12);
            KeyWords.Add("while", 13);
            KeyWords.Add("short", 14);
            KeyWords.Add("long", 15);
            KeyWords.Add("double", 16);
            KeyWords.Add("float", 17);
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "源文件(c)|*.c";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                txtBoxSource.Text = sr.ReadToEnd();
            }   
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "";
            Scanner sc = new Scanner(txtBoxSource.Text);
            string str=sc.scan();
            while (str != null)
            { 
                if (str.Length > 1)
                {
                   
                    txtBoxResult.Text +=string.Format("{0}\t{1}\r\n",sc.Line,str);
                }
                str = sc.scan();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit By Kaguya@CS&T_2010 \r\n\t2013.4");
        }
    }
}
