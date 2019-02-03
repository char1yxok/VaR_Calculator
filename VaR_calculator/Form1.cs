using System.Windows.Forms;
using System;

namespace VaR_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            BolatilityBar.Minimum = 0;
            BolatilityBar.Maximum = 100;
            BolatilityBar.TickStyle = TickStyle.None;
            BolatilityBar.SmallChange = 1;
            BolatilityBar.LargeChange = 10;
            BolatilityBar.Value = 0;
        }

        private void BolatilityBar_ValueChanged(object sender, System.EventArgs e)
        {
            BolLabel.Text = BolatilityBar.Value.ToString()+"%";
        }

        private void CalculationButton_Click(object sender, System.EventArgs e)
        {
            if (StockPrice.Text != "" && HoldingPeriod.Text != "")
            {
                double a = double.Parse(StockPrice.Text);

                VolatilityChart.Series.Clear();
                VolatilityChart.Legends.Clear();
                VolatilityChart.ChartAreas.Clear();

                string chartarea1 = "Area1";
                VolatilityChart.ChartAreas.Add(chartarea1);

                string Bol = "Bol1";
                VolatilityChart.Series.Add(Bol);
                VolatilityChart.Series[Bol].IsVisibleInLegend = false;
                VolatilityChart.Series[Bol].IsValueShownAsLabel = false;

                VolatilityChart.Series[Bol].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                //Gaussian Distribution
                var rnd = new Random();

                double X, Y;
                double Z1, Z2;

                for (int i = 0; i < 1000; i++)
                {
                    X = 1 - rnd.NextDouble();
                    Y = 1 - rnd.NextDouble();

                    Z1 = Math.Sqrt(-2.0 * Math.Log(X)) * Math.Cos(2.0 * Math.PI * Y);
                    Z2 = Math.Sqrt(-2.0 * Math.Log(X)) * Math.Sin(2.0 * Math.PI * Y) + a;
                    VolatilityChart.Series[Bol].Points.AddXY(Z2, Z1);

                    /*if (0.5 - rnd.NextDouble() > 0)
                    {
                        Z1 = Math.Sqrt(-2.0 * Math.Log(X)) * Math.Cos(2.0 * Math.PI * Y) + a;
                        VolatilityChart.Series[Bol].Points.AddXY(Z1,Z2); 
                    }
                    else
                    {
                        Z2 = Math.Sqrt(-2.0 * Math.Log(X)) * Math.Sin(2.0 * Math.PI * Y) + a;
                        VolatilityChart.Series[Bol].Points.Add(Z2);
                    }*/

                }

                double sp = 0; // Stock Price
                double sd = 0; // Standard Deviation
                double bt = 0; // Bolatility
                double hp = 0; // Holding Priod
                double result = 0;

                sp = double.Parse(StockPrice.Text);
                bt = BolatilityBar.Value * 0.01;
                hp = double.Parse(HoldingPeriod.Text);

                sd = sp * bt * Math.Sqrt(hp / 250) * 2.33;

                result = Math.Round(sp - sd);

                //VaR point
                string ResultPoint = "ResultPoint1";
                VolatilityChart.Series.Add(ResultPoint);
                VolatilityChart.Series[ResultPoint].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                VolatilityChart.Series[ResultPoint].MarkerColor = System.Drawing.Color.Red;
                VolatilityChart.Series[ResultPoint].Points.AddXY(sp - sd, 0);
                
                label5.Text = hp + "日の保有期間内に";
                label6.Text = "1%の確率で約" + result.ToString() + "円を下回る";
            }
            else if(StockPrice.Text == "" && HoldingPeriod.Text != "")
            {
                MessageBox.Show("株価を入力してください");
            }else if(StockPrice.Text != "" && HoldingPeriod.Text == "")
            {
                MessageBox.Show("保有期間を入力してください");
            }else if(StockPrice.Text == "" && HoldingPeriod.Text == "")
            {
                MessageBox.Show("株価と保有期間を入力してください");
            }
        }

        private void StockPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0' || '9'<e.KeyChar) && e.KeyChar!= '\b')
            {
                e.Handled = true;
            }
        }

        private void HoldingPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }


}
