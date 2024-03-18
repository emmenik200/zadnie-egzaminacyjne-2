using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadnie_egzaminacyjne_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string litery = "abcdefghijklmnoprstuwzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string liczby = "1234567890";
                string znaki = "!@#$%^&*";
                string pool = "";
                int number;
                //int range = (int)textBox3.Text;
                string text = textBox3.Text;
                bool ok = int.TryParse(text, out number);
                
            if (ok==true) 
            {
                int range = Convert.ToInt32(text);
                if (checkBox1.Checked)
                {

                    pool = pool + litery;



                }
                if (checkBox2.Checked)
                {
                    pool = pool + liczby;



                }
                if (checkBox3.Checked)
                {
                    pool = pool + znaki;


                }

                var random = new Random();
                var result = new string(
            Enumerable.Repeat(pool, range)
                        .Select(s => s[random.Next(s.Length)])
                        .ToArray());
                MessageBox.Show("wygenerowane hasło: ", result);

            }
            else
            {
                MessageBox.Show("W polu powinny znaleźć się same liczby");
            }

        }
    }
}
