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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.chart1.Name = "chart1";
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.listView1.Name = "listView1";
            this.listView1.TabIndex = 1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.TabIndex = 2;
            this.lblOverall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOverall.Padding = new System.Windows.Forms.Padding(8);
            this.lblOverall.ForeColor = System.Drawing.Color.Black;
            this.lblOverall.BackColor = System.Drawing.Color.Transparent;
            // 
            // ChartForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);

            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
