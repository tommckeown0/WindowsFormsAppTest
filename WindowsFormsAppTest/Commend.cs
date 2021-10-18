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

namespace WindowsFormsAppTest
{
    public partial class Commend : Form
    {
        public Commend()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string commend_Text_1 = textBox1.Text;
            string[] lines = { commend_Text_1 };
            
            string outputString = Std_Insp_2.commend_id + ".txt";

            if (!File.Exists(Std_Insp_2.commend_id + ".txt"))
            {
                File.WriteAllLines(outputString, lines);
            }
            else
            {
                File.AppendAllLines(outputString, lines);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Std_Insp_2 stdinsp2 = new Std_Insp_2();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
