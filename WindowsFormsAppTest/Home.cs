//************IGNORE FOR NOW****************
//DEPENDENCY: SelectPDF
//Tools > NuGet Package Manager > Package Manager Console.
//Enter this command: Install-Package Select.HtmlToPdf.NetCore -Version 21.1.0
//************IGNORE FOR NOW****************

//When saving an intervention/commendation, the message will be saved to a textfile in \WindowsFormsAppTest\bin\Debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SelectPdf;

namespace WindowsFormsAppTest
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            //MessageBox.Show(comboBox1.Text);

            //Standard site inspection
            //Hot works
            //Confined space
                        
            switch (comboBox1.Text)
            {
                case "Standard site inspection":
                    this.Hide();
                    Std_Insp_1 f2 = new Std_Insp_1();
                    f2.Show();
                    break;

                case "Hot works":
                    this.Hide();
                    Hot_Wrk f3 = new Hot_Wrk();
                    f3.Show();
                    break;

                case "Confined space":
                    this.Hide();
                    Conf_Sp f4 = new Conf_Sp();
                    f4.Show();
                    break;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Std_Insp_2 f1 = new Std_Insp_2();
            f1.Show();
        }
    }
}
