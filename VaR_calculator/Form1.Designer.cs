namespace VaR_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VolatilityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BolatilityBar = new System.Windows.Forms.TrackBar();
            this.BolLabel = new System.Windows.Forms.Label();
            this.StockPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HoldingPeriod = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VolatilityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolatilityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolatilityChart
            // 
            chartArea1.Name = "ChartArea1";
            this.VolatilityChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.VolatilityChart.Legends.Add(legend1);
            this.VolatilityChart.Location = new System.Drawing.Point(12, 12);
            this.VolatilityChart.Name = "VolatilityChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.VolatilityChart.Series.Add(series1);
            this.VolatilityChart.Size = new System.Drawing.Size(450, 300);
            this.VolatilityChart.TabIndex = 0;
            this.VolatilityChart.Text = "VolatilityChart";
            this.VolatilityChart.Series["Series1"].IsVisibleInLegend = false;
            this.VolatilityChart.Series["Series1"].IsValueShownAsLabel = false;
            // 
            // BolatilityBar
            // 
            this.BolatilityBar.Location = new System.Drawing.Point(12, 359);
            this.BolatilityBar.Name = "BolatilityBar";
            this.BolatilityBar.Size = new System.Drawing.Size(302, 56);
            this.BolatilityBar.TabIndex = 1;
            this.BolatilityBar.ValueChanged += new System.EventHandler(this.BolatilityBar_ValueChanged);
            // 
            // BolLabel
            // 
            this.BolLabel.AutoSize = true;
            this.BolLabel.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BolLabel.Location = new System.Drawing.Point(320, 359);
            this.BolLabel.Name = "BolLabel";
            this.BolLabel.Size = new System.Drawing.Size(29, 20);
            this.BolLabel.TabIndex = 2;
            this.BolLabel.Text = "0%";
            // 
            // StockPrice
            // 
            this.StockPrice.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StockPrice.Location = new System.Drawing.Point(538, 69);
            this.StockPrice.MaxLength = 9;
            this.StockPrice.Name = "StockPrice";
            this.StockPrice.Size = new System.Drawing.Size(107, 27);
            this.StockPrice.TabIndex = 3;
            this.StockPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(534, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "株価";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(651, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(651, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(534, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "保有期間";
            // 
            // HoldingPeriod
            // 
            this.HoldingPeriod.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HoldingPeriod.Location = new System.Drawing.Point(538, 122);
            this.HoldingPeriod.MaxLength = 6;
            this.HoldingPeriod.Name = "HoldingPeriod";
            this.HoldingPeriod.Size = new System.Drawing.Size(107, 27);
            this.HoldingPeriod.TabIndex = 6;
            this.HoldingPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoldingPeriod_KeyPress);
            // 
            // CalculationButton
            // 
            this.CalculationButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CalculationButton.Location = new System.Drawing.Point(574, 335);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(106, 44);
            this.CalculationButton.TabIndex = 9;
            this.CalculationButton.Text = "Enter";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(505, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(505, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HoldingPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockPrice);
            this.Controls.Add(this.BolLabel);
            this.Controls.Add(this.BolatilityBar);
            this.Controls.Add(this.VolatilityChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolatilityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolatilityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart VolatilityChart;
        private System.Windows.Forms.TrackBar BolatilityBar;
        private System.Windows.Forms.Label BolLabel;
        private System.Windows.Forms.TextBox StockPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HoldingPeriod;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

