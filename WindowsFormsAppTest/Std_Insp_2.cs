using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Std_Insp_2 : Form
    {
        public Std_Insp_2()
        {
            InitializeComponent();
        }

        public static string interv_id = "interv";
        public static string commend_id = "commend";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            interv_id = "intervA1";
            Interv interv = new Interv();
            interv.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            commend_id = "commendA1";
            Commend commend = new Commend();
            commend.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
