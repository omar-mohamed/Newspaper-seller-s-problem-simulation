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
    public partial class Demandprobabilitydistribution : Form
    {
        results_table rs;
        public List< double> good_dist;
        public List< double> fair_dist;
        public List< double>  poor_dist;
        public List<int> Demands;
        public static List<int> type;
        public static List<int> randomForNewsdayType;
        public static List<int> randomForDemand;
        public static List<int> FinalDemand;
        public Demandprobabilitydistribution()
        {
            InitializeComponent();
            Demands = new List<int>();
            good_dist = new List<double>();
            poor_dist = new List<double>();
            fair_dist = new List<double>();
            type = new List<int>();
            randomForDemand = new List<int>();
            randomForNewsdayType = new List<int>();
            FinalDemand = new List<int>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.numOfRows = this.dataGridView1.RowCount-1;
            for (int i = 0; i < 3; i++)
            {
                this.Demands.Add(Convert.ToInt32(this.dataGridView1.Rows[i].Cells[0].Value));
            }
            for (int i = 0; i < 3; i++)
            {
                this.good_dist.Add( Convert.ToDouble(this.dataGridView1.Rows[i].Cells[1].Value));
            }
            for (int i = 0; i < 3; i++)
            {
                this.fair_dist.Add(Convert.ToDouble(this.dataGridView1.Rows[i].Cells[2].Value));
            }
            for (int i = 0; i < 3; i++)
            {
                this.poor_dist.Add(Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value));
            }
            List<List<Random_generator.mynum >> ranges= new List<List<Random_generator. mynum>>();
            for(int i=0; i<3;i++)
            {
                List<Random_generator.mynum> temp;
                temp = Random_generator.newsday_paper_demand(good_dist, Demands);
                ranges.Add(temp);
            }
            randomForNewsdayType= new List<int>();
            type = Random_generator.newsday_type_assignment(Distribution_for_type_of_newsday.type_probability,ref randomForNewsdayType, Form1.numOfRows);
            randomForDemand = new List<int>();
            FinalDemand = Random_generator.final_demand(ranges,ref randomForDemand, type, Demands);

            rs = new results_table();
            
            rs.BringToFront();
            this.Close();
            rs.Show();

        }
    }
}
    