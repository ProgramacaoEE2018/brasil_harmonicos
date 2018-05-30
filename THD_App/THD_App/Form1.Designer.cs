namespace THD_App
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnBut = new System.Windows.Forms.Panel();
            this.lbVrmsNHarm = new System.Windows.Forms.Label();
            this.lbVrmsFund = new System.Windows.Forms.Label();
            this.btTHDr = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.lbNumHarm = new System.Windows.Forms.Label();
            this.lbFreqFund = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btCapturar = new System.Windows.Forms.Button();
            this.pnChart = new System.Windows.Forms.Panel();
            this.chtGraf3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtGraf2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtGraf1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnList = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbTabela = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pnBut.SuspendLayout();
            this.pnChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf1)).BeginInit();
            this.pnList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBut
            // 
            this.pnBut.Controls.Add(this.lbVrmsNHarm);
            this.pnBut.Controls.Add(this.lbVrmsFund);
            this.pnBut.Controls.Add(this.btTHDr);
            this.pnBut.Controls.Add(this.btParar);
            this.pnBut.Controls.Add(this.lbNumHarm);
            this.pnBut.Controls.Add(this.lbFreqFund);
            this.pnBut.Controls.Add(this.textBox2);
            this.pnBut.Controls.Add(this.textBox1);
            this.pnBut.Controls.Add(this.btSair);
            this.pnBut.Controls.Add(this.btCapturar);
            this.pnBut.Location = new System.Drawing.Point(12, 12);
            this.pnBut.Name = "pnBut";
            this.pnBut.Size = new System.Drawing.Size(236, 572);
            this.pnBut.TabIndex = 0;
            // 
            // lbVrmsNHarm
            // 
            this.lbVrmsNHarm.AutoSize = true;
            this.lbVrmsNHarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVrmsNHarm.Location = new System.Drawing.Point(28, 286);
            this.lbVrmsNHarm.Name = "lbVrmsNHarm";
            this.lbVrmsNHarm.Size = new System.Drawing.Size(165, 13);
            this.lbVrmsNHarm.TabIndex = 9;
            this.lbVrmsNHarm.Text = "Vrms do N-ésimo Harmônico";
            // 
            // lbVrmsFund
            // 
            this.lbVrmsFund.AutoSize = true;
            this.lbVrmsFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVrmsFund.Location = new System.Drawing.Point(28, 248);
            this.lbVrmsFund.Name = "lbVrmsFund";
            this.lbVrmsFund.Size = new System.Drawing.Size(195, 13);
            this.lbVrmsFund.TabIndex = 8;
            this.lbVrmsFund.Text = "Vrms da Frequência Fundamental";
            // 
            // btTHDr
            // 
            this.btTHDr.Location = new System.Drawing.Point(31, 400);
            this.btTHDr.Name = "btTHDr";
            this.btTHDr.Size = new System.Drawing.Size(169, 23);
            this.btTHDr.TabIndex = 7;
            this.btTHDr.Text = "Obter THDr";
            this.btTHDr.UseVisualStyleBackColor = true;
            this.btTHDr.Click += new System.EventHandler(this.btTHDr_Click);
            // 
            // btParar
            // 
            this.btParar.Location = new System.Drawing.Point(31, 359);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(169, 23);
            this.btParar.TabIndex = 6;
            this.btParar.Text = "Parar";
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // lbNumHarm
            // 
            this.lbNumHarm.AutoSize = true;
            this.lbNumHarm.Location = new System.Drawing.Point(13, 127);
            this.lbNumHarm.Name = "lbNumHarm";
            this.lbNumHarm.Size = new System.Drawing.Size(197, 13);
            this.lbNumHarm.TabIndex = 5;
            this.lbNumHarm.Text = "Número do Último Harmônico Relevante";
            // 
            // lbFreqFund
            // 
            this.lbFreqFund.AutoSize = true;
            this.lbFreqFund.Location = new System.Drawing.Point(21, 73);
            this.lbFreqFund.Name = "lbFreqFund";
            this.lbFreqFund.Size = new System.Drawing.Size(179, 13);
            this.lbFreqFund.TabIndex = 4;
            this.lbFreqFund.Text = "Frequência Fundamental da Entrada";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(31, 521);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(169, 23);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCapturar
            // 
            this.btCapturar.Location = new System.Drawing.Point(31, 191);
            this.btCapturar.Name = "btCapturar";
            this.btCapturar.Size = new System.Drawing.Size(169, 23);
            this.btCapturar.TabIndex = 0;
            this.btCapturar.Text = "Capturar";
            this.btCapturar.UseVisualStyleBackColor = true;
            this.btCapturar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.chtGraf3);
            this.pnChart.Controls.Add(this.chtGraf2);
            this.pnChart.Controls.Add(this.chtGraf1);
            this.pnChart.Location = new System.Drawing.Point(254, 12);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(405, 572);
            this.pnChart.TabIndex = 1;
            // 
            // chtGraf3
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGraf3.ChartAreas.Add(chartArea1);
            this.chtGraf3.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chtGraf3.Legends.Add(legend1);
            this.chtGraf3.Location = new System.Drawing.Point(0, 382);
            this.chtGraf3.Name = "chtGraf3";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtGraf3.Series.Add(series1);
            this.chtGraf3.Size = new System.Drawing.Size(405, 191);
            this.chtGraf3.TabIndex = 2;
            this.chtGraf3.Text = "chart1";
            // 
            // chtGraf2
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chtGraf2.ChartAreas.Add(chartArea2);
            this.chtGraf2.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chtGraf2.Legends.Add(legend2);
            this.chtGraf2.Location = new System.Drawing.Point(0, 191);
            this.chtGraf2.Name = "chtGraf2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtGraf2.Series.Add(series2);
            this.chtGraf2.Size = new System.Drawing.Size(405, 191);
            this.chtGraf2.TabIndex = 1;
            this.chtGraf2.Text = "chart2";
            // 
            // chtGraf1
            // 
            chartArea3.Name = "ChartArea1";
            this.chtGraf1.ChartAreas.Add(chartArea3);
            this.chtGraf1.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.chtGraf1.Legends.Add(legend3);
            this.chtGraf1.Location = new System.Drawing.Point(0, 0);
            this.chtGraf1.Name = "chtGraf1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtGraf1.Series.Add(series3);
            this.chtGraf1.Size = new System.Drawing.Size(405, 191);
            this.chtGraf1.TabIndex = 0;
            this.chtGraf1.Text = "chart1";
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.listView1);
            this.pnList.Location = new System.Drawing.Point(665, 45);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(254, 539);
            this.pnList.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 539);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // lbTabela
            // 
            this.lbTabela.AutoSize = true;
            this.lbTabela.Font = new System.Drawing.Font("Stencil", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabela.Location = new System.Drawing.Point(698, 12);
            this.lbTabela.Name = "lbTabela";
            this.lbTabela.Size = new System.Drawing.Size(196, 30);
            this.lbTabela.TabIndex = 3;
            this.lbTabela.Text = "Tabela de THD";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 596);
            this.Controls.Add(this.lbTabela);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnChart);
            this.Controls.Add(this.pnBut);
            this.Name = "Form1";
            this.Text = "Total Harmonic Distortion Calculator";
            this.pnBut.ResumeLayout(false);
            this.pnBut.PerformLayout();
            this.pnChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf1)).EndInit();
            this.pnList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBut;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCapturar;
        private System.Windows.Forms.Panel pnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraf2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraf1;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbTabela;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraf3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNumHarm;
        private System.Windows.Forms.Label lbFreqFund;
        private System.Windows.Forms.Button btTHDr;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.Label lbVrmsNHarm;
        private System.Windows.Forms.Label lbVrmsFund;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

