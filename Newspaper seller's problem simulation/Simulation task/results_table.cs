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
    public partial class results_table : Form
    {
        public static double scrap_value;
        public static double purchase;
        public static double sellingPrice;
        public static int numOfPapers;
        string[] typeofnewsDay;
        List<double> revenue;
        List<double> salvagefromscrap;
        List<double> excess_demand;
        List<double> profit;
        
        public results_table()
        {
            revenue = new List<double>();
            salvagefromscrap = new List<double>();
            excess_demand = new List<double>();
            profit = new List<double>();
            typeofnewsDay = new string[]{"Good","Fair","Poor"};
            InitializeComponent();
            calculate();
        }

        private void calculate()
        {
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                revenue.Add(Math.Min( Demandprobabilitydistribution.FinalDemand[i],numOfPapers) * sellingPrice);
            }
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                if (numOfPapers >= Demandprobabilitydistribution.FinalDemand[i])
                    excess_demand.Add(0);
                else
                    excess_demand.Add(( Demandprobabilitydistribution.FinalDemand[i]-numOfPapers) * (sellingPrice-purchase));
            }
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                if (Demandprobabilitydistribution.FinalDemand[i]- numOfPapers >= 0)
                    salvagefromscrap.Add(0);
                else 
                    salvagefromscrap.Add(( numOfPapers- Demandprobabilitydistribution.FinalDemand[i]) * scrap_value);
            }
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                profit.Add(revenue[i] - (numOfPapers * purchase) - excess_demand[i] + salvagefromscrap[i]);
            }
            print_table();
        }
        private void print_table()
        {
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
                this.dataGridView1.Rows[i].Cells[1].Value = Demandprobabilitydistribution.randomForNewsdayType[i];
                this.dataGridView1.Rows[i].Cells[3].Value = typeofnewsDay[ Demandprobabilitydistribution.type[i]];
                this.dataGridView1.Rows[i].Cells[3].Value = Demandprobabilitydistribution.randomForDemand[i];
                this.dataGridView1.Rows[i].Cells[4].Value = Demandprobabilitydistribution.FinalDemand[i];
                this.dataGridView1.Rows[i].Cells[5].Value = revenue[i];
                this.dataGridView1.Rows[i].Cells[6].Value = excess_demand[i];
                this.dataGridView1.Rows[i].Cells[7].Value = salvagefromscrap[i];
                this.dataGridView1.Rows[i].Cells[8].Value = profit[i];
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
