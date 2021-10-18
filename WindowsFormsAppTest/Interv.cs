using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppTest
{
    public partial class Interv : Form
    {

        string path = "Data Source= DESKTOP-NQL9UQO; Initial Catalog = siteinspection; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;

        public Interv()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }
        
        private void Interv_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string interv_Text_1 = textBox1.Text;
            string interv_Text_2 = textBox2.Text;
            bool completed = checkBox1.Checked;
            string[] lines;

            if (completed == true)
            {
                lines = new string[] { interv_Text_1, interv_Text_2, "1" };
            }
            else
            {
                lines = new string[] { interv_Text_1, interv_Text_2, "0" };
            }

            string outputString = Std_Insp_2.interv_id + ".txt";
            
            if (!File.Exists(Std_Insp_2.interv_id + ".txt"))
            {
                File.WriteAllLines(outputString, lines);
            }
            else
            {
                File.AppendAllLines(outputString, lines);
            }

            string compString = completed.ToString();

            try
            {
                con.Open();
                cmd = new SqlCommand("Insert into Intervention (Intervention_Details, Intervention_Actions, Intervention_Completed)" +
                    " values ('"+ interv_Text_1 + "', '" + interv_Text_2 + "', '" + compString + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your data has been saved into the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
