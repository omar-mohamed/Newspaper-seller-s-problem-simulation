using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_task
{
    class Random_generator
    {
        public struct mynum
        {
            public int left, right;

        };
        public static List<int> newsday_type_assignment(List<double> probability, ref List<int> random_numbers, int num)
        {
            List<int> type=new List<int>();
            List<double> cumulative = new List<double>();
            double x = 0.0;
            for (int i = 0; i < probability.Count; i++)
            {
                cumulative.Add(probability[i]);
                cumulative[i] += x;
                x = cumulative[i];
            }
            List<mynum> range = new List<mynum>();
            int Left = 0;
            mynum y = new mynum();

            for (int i = 0; i < probability.Count; i++)
            {
                y.left = Left;
                y.right = (int)(cumulative[i] * 100) - 1;
                range.Add(y);
                Left = (int)(cumulative[i] * 100);
            }
            Random rand = new Random(System.DateTime.Now.Millisecond);

            for (int i = 0; i < num; i++)
            {
                int X = rand.Next(0, 100);
                random_numbers.Add(X);
                for (int j = 0; j < probability.Count; j++)
                {
                    if (X >= range[j].left && X <= range[j].right)
                    {
                        type.Add(j);
                        break;
                    }
                }
            }
            return type;
        }
        public static List<mynum> newsday_paper_demand(List<double> probability, List<int> demand)
        {
            List<double> cumulative = new List<double>();
            double x = 0.0;
            for (int i = 0; i < probability.Count; i++)
            {
                cumulative.Add(probability[i]);
                cumulative[i] += x;
                x = cumulative[i];
            }
            List<mynum> range = new List<mynum>();
            int Left = 0;
            mynum y = new mynum();

            for (int i = 0; i < probability.Count; i++)
            {
                y.left = Left;
                y.right = (int)(cumulative[i] * 100) - 1;
                range.Add(y);
                Left = (int)(cumulative[i] * 100);
            }
            return range;
        }
        public static List<int> final_demand(List<List<mynum>> ranges, ref List<int> random_numbers, List<int> type,List<int>demands)
        {
            Random rand = new Random(System.DateTime.Now.Millisecond);
            List<int> demand = new List<int>();
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                int X = rand.Next(0, 99);
                random_numbers.Add(X);
                for (int k = 0; k < ranges[type[i]].Count; k++)
                {
                    if (X >= ranges[type[i]][k].left && X <= ranges[type[i]][k].right)
                    {
                        demand.Add(demands[k]);
                        break;
                    }
                }

            }
            return demand;
        }
    }
}