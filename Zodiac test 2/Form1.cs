using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zodiac_test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int luna, ziua;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime data = monthCalendar1.SelectionRange.Start;
            luna = data.Month;
            ziua = data.Day;
            if ((luna == 1 && ziua >= 20) || (luna == 2 && ziua <= 18)) //varsator
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("varsator" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 2 && ziua >= 19) || (luna == 3 && ziua <= 20)) //pesti
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("pesti" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 3 && ziua >= 21) || (luna == 4 && ziua <= 20)) //berbec
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("berbec" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 4 && ziua >= 21) || (luna == 5 && ziua <= 21)) //taur
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("taur" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 5 && ziua >= 22) || (luna == 6 && ziua <= 21)) //gemeni
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("gemeni" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 6 && ziua >= 22) || (luna == 7 && ziua <= 22)) //rac
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("rac" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 7 && ziua >= 23) || (luna == 8 && ziua <= 22)) //leu
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("leu" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 8 && ziua >= 23) || (luna == 9 && ziua <= 21)) //fecioara
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("fecioara" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 9 && ziua >= 22) || (luna == 10 && ziua <= 22)) //balanta
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("balanta" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 10 && ziua >= 23) || (luna == 11 && ziua <= 21)) //scorpion
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("scorpion" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 11 && ziua >= 22) || (luna == 12 && ziua <= 21)) //sagetator
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("sagetator" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
            if ((luna == 12 && ziua >= 22) || (luna == 1 && ziua <= 19)) //capricorn
            {
                textBox1.Clear();
                StreamReader f;
                f = File.OpenText("capricorn" + ".txt");
                String s;
                s = f.ReadLine();
                while (s != null)
                {
                    textBox1.Text += s + "\r\n";
                    s = f.ReadLine();
                }
                f.Close();
            }
        }
    }
}
