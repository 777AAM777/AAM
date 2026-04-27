namespace AAM
{
    partial class MainForm
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
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.numSorCount = new System.Windows.Forms.NumericUpDown();
            this.pnlSor = new System.Windows.Forms.Panel();
            this.numSochScore = new System.Windows.Forms.NumericUpDown();
            this.numSochMax = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnGoToChart = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSochScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSochMax)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(12, 12);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(200, 21);
            this.cmbSubjects.TabIndex = 0;
            // 
            // lblSubject
            // 
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, -1);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 13);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "Предмет:";
            // 
            // numSorCount
            // 
            this.numSorCount.Location = new System.Drawing.Point(220, 12);
            this.numSorCount.Minimum = 1;
            this.numSorCount.Maximum = 8;
            this.numSorCount.Name = "numSorCount";
            this.numSorCount.Size = new System.Drawing.Size(40, 20);
            this.numSorCount.TabIndex = 1;
            this.numSorCount.ValueChanged += new System.EventHandler(this.numSorCount_ValueChanged);
            // 
            // lblSorCount
            // 
            this.lblSorCount = new System.Windows.Forms.Label();
            this.lblSorCount.AutoSize = true;
            this.lblSorCount.Location = new System.Drawing.Point(220, -1);
            this.lblSorCount.Name = "lblSorCount";
            this.lblSorCount.Size = new System.Drawing.Size(95, 13);
            this.lblSorCount.TabIndex = 21;
            this.lblSorCount.Text = "Кол-во СОР:";
            // 
            // lblQuarter
            // 
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(270,  -1);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(50, 13);
            this.lblQuarter.TabIndex = 10;
            this.lblQuarter.Text = "Четверть:";
            // 
            // cmbQuarter
            // 
            this.cmbQuarter = new System.Windows.Forms.ComboBox();
            this.cmbQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuarter.FormattingEnabled = true;
            this.cmbQuarter.Location = new System.Drawing.Point(270, 12);
            this.cmbQuarter.Name = "cmbQuarter";
            this.cmbQuarter.Size = new System.Drawing.Size(80, 21);
            this.cmbQuarter.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(360, -1);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Год:";
            // 
            // numYear
            // 
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numYear.Location = new System.Drawing.Point(360, 12);
            this.numYear.Minimum = 2000;
            this.numYear.Maximum = 2100;
            this.numYear.Value = 2024;
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(60, 20);
            this.numYear.TabIndex = 13;
            // 
            // pnlSor
            // 
            this.pnlSor.AutoScroll = true;
            this.pnlSor.Location = new System.Drawing.Point(12, 40);
            this.pnlSor.Name = "pnlSor";
            this.pnlSor.Size = new System.Drawing.Size(260, 200);
            this.pnlSor.TabIndex = 2;
            // 
            // numSochScore
            // 
            this.numSochScore.DecimalPlaces = 1;
            this.numSochScore.Location = new System.Drawing.Point(12, 250);
            this.numSochScore.Maximum = 100;
            this.numSochScore.Name = "numSochScore";
            this.numSochScore.Size = new System.Drawing.Size(80, 20);
            this.numSochScore.TabIndex = 3;
            // 
            // numSochMax
            // 
            this.numSochMax.Location = new System.Drawing.Point(100, 250);
            this.numSochMax.Maximum = 100;
            this.numSochMax.Name = "numSochMax";
            this.numSochMax.Size = new System.Drawing.Size(80, 20);
            this.numSochMax.TabIndex = 4;
            this.numSochMax.Value = 40;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 280);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 30);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnGoToChart
            // 
            this.btnGoToChart.Location = new System.Drawing.Point(100, 280);
            this.btnGoToChart.Name = "btnGoToChart";
            this.btnGoToChart.Size = new System.Drawing.Size(80, 30);
            this.btnGoToChart.TabIndex = 6;
            this.btnGoToChart.Text = "График";
            this.btnGoToChart.UseVisualStyleBackColor = true;
            this.btnGoToChart.Click += new System.EventHandler(this.btnGoToChart_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(190, 280);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(80, 30);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 320);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(12, 340);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 13);
            this.lblGrade.TabIndex = 9;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.numSorCount);
            this.Controls.Add(this.lblSorCount);
            this.Controls.Add(this.lblQuarter);
            this.Controls.Add(this.cmbQuarter);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.pnlSor);
            this.Controls.Add(this.numSochScore);
            this.Controls.Add(this.numSochMax);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnGoToChart);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGrade);
            this.Name = "MainForm";
            this.Text = "AAM - Главная";
            ((System.ComponentModel.ISupportInitialize)(this.numSorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSochScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSochMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.NumericUpDown numSorCount;
        private System.Windows.Forms.Label lblSorCount;
        private System.Windows.Forms.Panel pnlSor;
        private System.Windows.Forms.NumericUpDown numSochScore;
        private System.Windows.Forms.NumericUpDown numSochMax;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnGoToChart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cmbQuarter;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label lblYear;
    }
}
