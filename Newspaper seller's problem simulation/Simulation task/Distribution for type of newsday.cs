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
    public partial class Distribution_for_type_of_newsday : Form
    {
        public static List< double> type_probability;

        public Distribution_for_type_of_newsday()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Demandprobabilitydistribution ds = new Demandprobabilitydistribution();
            type_probability = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                type_probability.Add( Convert.ToDouble(this.dataGridView1.Rows[i].Cells[0].Value));
            }

            ds.BringToFront();
            this.Close();
            ds.Show();

        }
    }
}
