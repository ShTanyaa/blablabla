namespace praktica16
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series99 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series100 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series101 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series102 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series103 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series104 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series105 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.синусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синусToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.косинусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гиперболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кубФToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.косToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea15.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart1.Legends.Add(legend15);
            this.chart1.Location = new System.Drawing.Point(41, 52);
            this.chart1.Name = "chart1";
            series99.ChartArea = "ChartArea1";
            series99.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series99.Legend = "Legend1";
            series99.Name = "синус";
            series100.ChartArea = "ChartArea1";
            series100.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series100.Legend = "Legend1";
            series100.Name = "косинус";
            series101.ChartArea = "ChartArea1";
            series101.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series101.Legend = "Legend1";
            series101.Name = "Гипербола";
            series102.ChartArea = "ChartArea1";
            series102.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series102.Legend = "Legend1";
            series102.Name = "Парабола";
            series103.ChartArea = "ChartArea1";
            series103.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series103.Legend = "Legend1";
            series103.Name = "Кубическая функция";
            series104.ChartArea = "ChartArea1";
            series104.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series104.Legend = "Legend1";
            series104.Name = "sin";
            series105.ChartArea = "ChartArea1";
            series105.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series105.Legend = "Legend1";
            series105.Name = "cos";
            this.chart1.Series.Add(series99);
            this.chart1.Series.Add(series100);
            this.chart1.Series.Add(series101);
            this.chart1.Series.Add(series102);
            this.chart1.Series.Add(series103);
            this.chart1.Series.Add(series104);
            this.chart1.Series.Add(series105);
            this.chart1.Size = new System.Drawing.Size(487, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(255, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "введи значение а";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "введи значение в\r\n";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(653, 132);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(653, 232);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.синусToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // синусToolStripMenuItem
            // 
            this.синусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.синусToolStripMenuItem1,
            this.косинусToolStripMenuItem,
            this.гиперболаToolStripMenuItem,
            this.параболаToolStripMenuItem,
            this.кубФToolStripMenuItem,
            this.синToolStripMenuItem,
            this.косToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.синусToolStripMenuItem.Name = "синусToolStripMenuItem";
            this.синусToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.синусToolStripMenuItem.Text = "задание";
            this.синусToolStripMenuItem.Click += new System.EventHandler(this.синусToolStripMenuItem_Click_1);
            // 
            // синусToolStripMenuItem1
            // 
            this.синусToolStripMenuItem1.Name = "синусToolStripMenuItem1";
            this.синусToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.синусToolStripMenuItem1.Text = "синус";
            this.синусToolStripMenuItem1.Click += new System.EventHandler(this.синусToolStripMenuItem1_Click);
            // 
            // косинусToolStripMenuItem
            // 
            this.косинусToolStripMenuItem.Name = "косинусToolStripMenuItem";
            this.косинусToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.косинусToolStripMenuItem.Text = "косинус";
            this.косинусToolStripMenuItem.Click += new System.EventHandler(this.косинусToolStripMenuItem_Click);
            // 
            // гиперболаToolStripMenuItem
            // 
            this.гиперболаToolStripMenuItem.Name = "гиперболаToolStripMenuItem";
            this.гиперболаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гиперболаToolStripMenuItem.Text = "гипербола";
            this.гиперболаToolStripMenuItem.Click += new System.EventHandler(this.гиперболаToolStripMenuItem_Click);
            // 
            // параболаToolStripMenuItem
            // 
            this.параболаToolStripMenuItem.Name = "параболаToolStripMenuItem";
            this.параболаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.параболаToolStripMenuItem.Text = "парабола";
            this.параболаToolStripMenuItem.Click += new System.EventHandler(this.параболаToolStripMenuItem_Click);
            // 
            // кубФToolStripMenuItem
            // 
            this.кубФToolStripMenuItem.Name = "кубФToolStripMenuItem";
            this.кубФToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кубФToolStripMenuItem.Text = "куб ф";
            this.кубФToolStripMenuItem.Click += new System.EventHandler(this.кубФToolStripMenuItem_Click);
            // 
            // синToolStripMenuItem
            // 
            this.синToolStripMenuItem.Name = "синToolStripMenuItem";
            this.синToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.синToolStripMenuItem.Text = "син";
            this.синToolStripMenuItem.Click += new System.EventHandler(this.синToolStripMenuItem_Click);
            // 
            // косToolStripMenuItem
            // 
            this.косToolStripMenuItem.Name = "косToolStripMenuItem";
            this.косToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.косToolStripMenuItem.Text = "кос";
            this.косToolStripMenuItem.Click += new System.EventHandler(this.косToolStripMenuItem_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(653, 325);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "введи значение c\r\n";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem синусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синусToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem косинусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гиперболаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параболаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кубФToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem косToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

