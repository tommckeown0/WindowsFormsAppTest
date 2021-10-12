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
                    Std_Insp f2 = new Std_Insp();
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
    }
}
