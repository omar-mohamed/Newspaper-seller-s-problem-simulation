using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_task
{
    public partial class Form1 : Form
    {
        public static int numOfRows,numOfCols;
        Distribution_for_type_of_newsday st;
        public Form1()
        {
            InitializeComponent();
            numOfCols = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st = new Distribution_for_type_of_newsday();
            st.BringToFront();
            st.Show();
           // this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            results_table.purchase = Convert.ToDouble(textBox2.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            results_table.scrap_value = Convert.ToDouble(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            results_table.sellingPrice = Convert.ToDouble(textBox6.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            results_table.numOfPapers = Convert.ToInt32(textBox8.Text);
        }

        

    }
}