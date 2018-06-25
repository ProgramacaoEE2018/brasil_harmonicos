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
            this.gbFinalizar = new System.Windows.Forms.GroupBox();
            this.btLimparDados = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.numFFund = new System.Windows.Forms.NumericUpDown();
            this.numNHarm = new System.Windows.Forms.NumericUpDown();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbSin = new System.Windows.Forms.RadioButton();
            this.btGerarEntrada = new System.Windows.Forms.Button();
            this.btInicializar = new System.Windows.Forms.Button();
            this.lbFreqFund = new System.Windows.Forms.Label();
            this.btTHDr = new System.Windows.Forms.Button();
            this.lbNumHarm = new System.Windows.Forms.Label();
            this.btObterSaida = new System.Windows.Forms.Button();
            this.pnChart = new System.Windows.Forms.Panel();
            this.chtGraf1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtGraf3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtGraf2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnList = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbTabela = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVrmsHarm = new System.Windows.Forms.Label();
            this.pnBut.SuspendLayout();
            this.gbFinalizar.SuspendLayout();
            this.gbEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFFund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNHarm)).BeginInit();
            this.pnChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf2)).BeginInit();
            this.pnList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBut
            // 
            this.pnBut.Controls.Add(this.gbFinalizar);
            this.pnBut.Controls.Add(this.gbEntrada);
            this.pnBut.Location = new System.Drawing.Point(12, 12);
            this.pnBut.Name = "pnBut";
            this.pnBut.Size = new System.Drawing.Size(236, 572);
            this.pnBut.TabIndex = 0;
            // 
            // gbFinalizar
            // 
            this.gbFinalizar.Controls.Add(this.btLimparDados);
            this.gbFinalizar.Controls.Add(this.btSair);
            this.gbFinalizar.Location = new System.Drawing.Point(3, 435);
            this.gbFinalizar.Name = "gbFinalizar";
            this.gbFinalizar.Size = new System.Drawing.Size(222, 134);
            this.gbFinalizar.TabIndex = 12;
            this.gbFinalizar.TabStop = false;
            this.gbFinalizar.Text = "Resetar";
            // 
            // btLimparDados
            // 
            this.btLimparDados.Location = new System.Drawing.Point(28, 38);
            this.btLimparDados.Name = "btLimparDados";
            this.btLimparDados.Size = new System.Drawing.Size(169, 23);
            this.btLimparDados.TabIndex = 6;
            this.btLimparDados.Text = "Limpar Dados";
            this.btLimparDados.UseVisualStyleBackColor = true;
            this.btLimparDados.Click += new System.EventHandler(this.btLimparDados_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(28, 90);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(169, 23);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.numFFund);
            this.gbEntrada.Controls.Add(this.numNHarm);
            this.gbEntrada.Controls.Add(this.rbSquare);
            this.gbEntrada.Controls.Add(this.rbSin);
            this.gbEntrada.Controls.Add(this.btGerarEntrada);
            this.gbEntrada.Controls.Add(this.btInicializar);
            this.gbEntrada.Controls.Add(this.lbFreqFund);
            this.gbEntrada.Controls.Add(this.btTHDr);
            this.gbEntrada.Controls.Add(this.lbNumHarm);
            this.gbEntrada.Controls.Add(this.btObterSaida);
            this.gbEntrada.Location = new System.Drawing.Point(3, 3);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(220, 284);
            this.gbEntrada.TabIndex = 10;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // numFFund
            // 
            this.numFFund.Location = new System.Drawing.Point(35, 70);
            this.numFFund.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numFFund.Name = "numFFund";
            this.numFFund.Size = new System.Drawing.Size(169, 20);
            this.numFFund.TabIndex = 12;
            this.numFFund.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // numNHarm
            // 
            this.numNHarm.Location = new System.Drawing.Point(35, 109);
            this.numNHarm.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numNHarm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNHarm.Name = "numNHarm";
            this.numNHarm.Size = new System.Drawing.Size(169, 20);
            this.numNHarm.TabIndex = 7;
            this.numNHarm.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(119, 142);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(72, 17);
            this.rbSquare.TabIndex = 11;
            this.rbSquare.Text = "Quadrada";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbSin
            // 
            this.rbSin.AutoSize = true;
            this.rbSin.Checked = true;
            this.rbSin.Location = new System.Drawing.Point(35, 142);
            this.rbSin.Name = "rbSin";
            this.rbSin.Size = new System.Drawing.Size(66, 17);
            this.rbSin.TabIndex = 10;
            this.rbSin.TabStop = true;
            this.rbSin.Text = "Senoidal";
            this.rbSin.UseVisualStyleBackColor = true;
            // 
            // btGerarEntrada
            // 
            this.btGerarEntrada.Location = new System.Drawing.Point(35, 165);
            this.btGerarEntrada.Name = "btGerarEntrada";
            this.btGerarEntrada.Size = new System.Drawing.Size(169, 23);
            this.btGerarEntrada.TabIndex = 9;
            this.btGerarEntrada.Text = "Gerar Entrada";
            this.btGerarEntrada.UseVisualStyleBackColor = true;
            this.btGerarEntrada.Click += new System.EventHandler(this.btGerarEntrada_Click);
            // 
            // btInicializar
            // 
            this.btInicializar.Location = new System.Drawing.Point(35, 19);
            this.btInicializar.Name = "btInicializar";
            this.btInicializar.Size = new System.Drawing.Size(169, 23);
            this.btInicializar.TabIndex = 8;
            this.btInicializar.Text = "Inicializar";
            this.btInicializar.UseVisualStyleBackColor = true;
            this.btInicializar.Click += new System.EventHandler(this.btInicializar_Click);
            // 
            // lbFreqFund
            // 
            this.lbFreqFund.AutoSize = true;
            this.lbFreqFund.Location = new System.Drawing.Point(32, 54);
            this.lbFreqFund.Name = "lbFreqFund";
            this.lbFreqFund.Size = new System.Drawing.Size(179, 13);
            this.lbFreqFund.TabIndex = 4;
            this.lbFreqFund.Text = "Frequência Fundamental da Entrada";
            // 
            // btTHDr
            // 
            this.btTHDr.Location = new System.Drawing.Point(35, 257);
            this.btTHDr.Name = "btTHDr";
            this.btTHDr.Size = new System.Drawing.Size(169, 23);
            this.btTHDr.TabIndex = 7;
            this.btTHDr.Text = "Obter THDr";
            this.btTHDr.UseVisualStyleBackColor = true;
            this.btTHDr.Click += new System.EventHandler(this.btTHDr_Click);
            // 
            // lbNumHarm
            // 
            this.lbNumHarm.AutoSize = true;
            this.lbNumHarm.Location = new System.Drawing.Point(25, 93);
            this.lbNumHarm.Name = "lbNumHarm";
            this.lbNumHarm.Size = new System.Drawing.Size(197, 13);
            this.lbNumHarm.TabIndex = 5;
            this.lbNumHarm.Text = "Número do Último Harmônico Relevante";
            // 
            // btObterSaida
            // 
            this.btObterSaida.Location = new System.Drawing.Point(35, 228);
            this.btObterSaida.Name = "btObterSaida";
            this.btObterSaida.Size = new System.Drawing.Size(169, 23);
            this.btObterSaida.TabIndex = 0;
            this.btObterSaida.Text = "Obter Saída";
            this.btObterSaida.UseVisualStyleBackColor = true;
            this.btObterSaida.Click += new System.EventHandler(this.btObterSaida_Click);
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.chtGraf1);
            this.pnChart.Controls.Add(this.chtGraf3);
            this.pnChart.Controls.Add(this.chtGraf2);
            this.pnChart.Location = new System.Drawing.Point(254, 12);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(405, 572);
            this.pnChart.TabIndex = 1;
            // 
            // chtGraf1
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGraf1.ChartAreas.Add(chartArea1);
            this.chtGraf1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chtGraf1.Legends.Add(legend1);
            this.chtGraf1.Location = new System.Drawing.Point(0, 382);
            this.chtGraf1.Name = "chtGraf1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtGraf1.Series.Add(series1);
            this.chtGraf1.Size = new System.Drawing.Size(405, 191);
            this.chtGraf1.TabIndex = 3;
            this.chtGraf1.Text = "chart1";
            // 
            // chtGraf3
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.Name = "ChartArea1";
            this.chtGraf3.ChartAreas.Add(chartArea2);
            this.chtGraf3.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chtGraf3.Legends.Add(legend2);
            this.chtGraf3.Location = new System.Drawing.Point(0, 191);
            this.chtGraf3.Name = "chtGraf3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chtGraf3.Series.Add(series2);
            this.chtGraf3.Size = new System.Drawing.Size(405, 191);
            this.chtGraf3.TabIndex = 2;
            this.chtGraf3.Text = "chart1";
            // 
            // chtGraf2
            // 
            chartArea3.Name = "ChartArea1";
            this.chtGraf2.ChartAreas.Add(chartArea3);
            this.chtGraf2.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.chtGraf2.Legends.Add(legend3);
            this.chtGraf2.Location = new System.Drawing.Point(0, 0);
            this.chtGraf2.Name = "chtGraf2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtGraf2.Series.Add(series3);
            this.chtGraf2.Size = new System.Drawing.Size(405, 191);
            this.chtGraf2.TabIndex = 1;
            this.chtGraf2.Text = "chart2";
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.listView1);
            this.pnList.Location = new System.Drawing.Point(698, 337);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(151, 235);
            this.pnList.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(151, 235);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // lbTabela
            // 
            this.lbTabela.AutoSize = true;
            this.lbTabela.Font = new System.Drawing.Font("High Tower Text", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabela.Location = new System.Drawing.Point(684, 292);
            this.lbTabela.Name = "lbTabela";
            this.lbTabela.Size = new System.Drawing.Size(175, 29);
            this.lbTabela.TabIndex = 3;
            this.lbTabela.Text = "Tabela de THD";
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(151, 235);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Location = new System.Drawing.Point(698, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 235);
            this.panel1.TabIndex = 5;
            // 
            // lbVrmsHarm
            // 
            this.lbVrmsHarm.AutoSize = true;
            this.lbVrmsHarm.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVrmsHarm.Location = new System.Drawing.Point(685, 17);
            this.lbVrmsHarm.Name = "lbVrmsHarm";
            this.lbVrmsHarm.Size = new System.Drawing.Size(177, 19);
            this.lbVrmsHarm.TabIndex = 6;
            this.lbVrmsHarm.Text = "Vrms dos Harmônicos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 637);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTabela);
            this.Controls.Add(this.lbVrmsHarm);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnChart);
            this.Controls.Add(this.pnBut);
            this.Name = "Form1";
            this.Text = "Total Harmonic Distortion Calculator";
            this.pnBut.ResumeLayout(false);
            this.gbFinalizar.ResumeLayout(false);
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFFund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNHarm)).EndInit();
            this.pnChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraf2)).EndInit();
            this.pnList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBut;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btObterSaida;
        private System.Windows.Forms.Panel pnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraf2;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbTabela;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraf3;
        private System.Windows.Forms.Label lbNumHarm;
        private System.Windows.Forms.Label lbFreqFund;
        private System.Windows.Forms.Button btTHDr;
        private System.Windows.Forms.Button btLimparDados;
        private System.Windows.Forms.GroupBox gbFinalizar;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.Button btGerarEntrada;
        private System.Windows.Forms.Button btInicializar;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbSin;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVrmsHarm;
        private System.Windows.Forms.NumericUpDown numNHarm;
        private System.Windows.Forms.NumericUpDown numFFund;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraf1;
    }
}

