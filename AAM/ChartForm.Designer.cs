namespace AAM
{
    partial class ChartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumeric = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuarter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOverall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            var legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1.ChartAreas.Add(chartArea);
            this.chart1.Legends.Add(legend);
            // подписи осей на русском
            this.chart1.ChartAreas[0].AxisX.Title = "Предметы";
            this.chart1.ChartAreas[0].AxisY.Title = "Процент (%)";
            this.chart1.Legends[0].Title = "Периоды";
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(760, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPercent,
            this.columnHeaderNumeric,
            this.columnHeaderYear,
            this.columnHeaderQuarter});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 320);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 200);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Предмет";
            this.columnHeaderName.Width = 300;
            // 
            // columnHeaderPercent
            // 
            this.columnHeaderPercent.Text = "Процент";
            this.columnHeaderPercent.Width = 100;
            // 
            // columnHeaderNumeric
            // 
            this.columnHeaderNumeric.Text = "Средняя оценка";
            this.columnHeaderNumeric.Width = 120;
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Учебный год";
            this.columnHeaderYear.Width = 80;
            // 
            // columnHeaderQuarter
            // 
            this.columnHeaderQuarter.Text = "Четверть";
            this.columnHeaderQuarter.Width = 80;
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Location = new System.Drawing.Point(12, 525);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(0, 13);
            this.lblOverall.TabIndex = 2;
            // 
            // ChartForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblOverall);
            this.Name = "ChartForm";
            this.Text = "График";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPercent;
        private System.Windows.Forms.ColumnHeader columnHeaderNumeric;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderQuarter;
        private System.Windows.Forms.Label lblOverall;
    }
}
