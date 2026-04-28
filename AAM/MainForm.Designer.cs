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
            this.cmbSubjects.Location = new System.Drawing.Point(12, 28);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(260, 25);
            this.cmbSubjects.TabIndex = 0;
            this.cmbSubjects.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.BackColor = System.Drawing.Color.White;
            this.cmbSubjects.ForeColor = System.Drawing.Color.Black;
            // 
            // lblSubject
            // 
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 8);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(60, 15);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "Предмет:";
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubject.ForeColor = System.Drawing.Color.Black;
            // 
            // numSorCount
            // 
            this.numSorCount.Location = new System.Drawing.Point(280, 28);
            this.numSorCount.Minimum = 1;
            this.numSorCount.Maximum = 8;
            this.numSorCount.Name = "numSorCount";
            this.numSorCount.Size = new System.Drawing.Size(40, 20);
            this.numSorCount.TabIndex = 1;
            this.numSorCount.ValueChanged += new System.EventHandler(this.numSorCount_ValueChanged);
            this.numSorCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // lblSorCount
            // 
            this.lblSorCount = new System.Windows.Forms.Label();
            this.lblSorCount.AutoSize = true;
            this.lblSorCount.Location = new System.Drawing.Point(290, 8);
            this.lblSorCount.Name = "lblSorCount";
            this.lblSorCount.Size = new System.Drawing.Size(85, 15);
            this.lblSorCount.TabIndex = 21;
            this.lblSorCount.Text = "Кол-во СОР:";
            this.lblSorCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSorCount.ForeColor = System.Drawing.Color.Black;
            // 
            // lblQuarter
            // 
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(450, 8);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(58, 15);
            this.lblQuarter.TabIndex = 10;
            this.lblQuarter.Text = "Четверть:";
            this.lblQuarter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuarter.ForeColor = System.Drawing.Color.Black;
            // 
            // cmbQuarter
            // 
            this.cmbQuarter = new System.Windows.Forms.ComboBox();
            this.cmbQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuarter.FormattingEnabled = true;
            this.cmbQuarter.Location = new System.Drawing.Point(360, 28);
            this.cmbQuarter.Name = "cmbQuarter";
            this.cmbQuarter.Size = new System.Drawing.Size(60, 25);
            this.cmbQuarter.TabIndex = 11;
            this.cmbQuarter.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // lblYear
            // 
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(560, 8);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(70, 15);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Учебный год:";
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            // 
            // numYear
            // 
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numYear.Location = new System.Drawing.Point(540, 28);
            this.numYear.Minimum = 2000;
            this.numYear.Maximum = 2100;
            this.numYear.Value = 2024;
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(80, 25);
            this.numYear.TabIndex = 13;
            this.numYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // pnlSor
            // 
            this.pnlSor.AutoScroll = true;
            this.pnlSor.Location = new System.Drawing.Point(12, 70);
            this.pnlSor.Name = "pnlSor";
            this.pnlSor.Size = new System.Drawing.Size(460, 260);
            this.pnlSor.TabIndex = 2;
            this.pnlSor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSor.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // numSochScore
            // 
            this.numSochScore.DecimalPlaces = 1;
            this.numSochScore.Location = new System.Drawing.Point(490, 110);
            this.numSochScore.Maximum = 100;
            this.numSochScore.Name = "numSochScore";
            this.numSochScore.Size = new System.Drawing.Size(100, 25);
            this.numSochScore.TabIndex = 3;
            this.numSochScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // numSochMax
            // 
            this.numSochMax.Location = new System.Drawing.Point(600, 110);
            this.numSochMax.Maximum = 100;
            this.numSochMax.Name = "numSochMax";
            this.numSochMax.Size = new System.Drawing.Size(100, 25);
            this.numSochMax.TabIndex = 4;
            this.numSochMax.Value = 40;
            this.numSochMax.Font = new System.Drawing.Font("Segoe UI", 9F);

            // lblSoch
            //
            this.lblSoch = new System.Windows.Forms.Label();
            this.lblSoch.AutoSize = true;
            this.lblSoch.Location = new System.Drawing.Point(490, 88);
            this.lblSoch.Name = "lblSoch";
            this.lblSoch.Size = new System.Drawing.Size(120, 15);
            this.lblSoch.TabIndex = 22;
            this.lblSoch.Text = "СОЧ (балл / макс):";
            this.lblSoch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoch.ForeColor = System.Drawing.Color.Black;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(490, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnGoToChart
            // 
            this.btnGoToChart.Location = new System.Drawing.Point(610, 150);
            this.btnGoToChart.Name = "btnGoToChart";
            this.btnGoToChart.Size = new System.Drawing.Size(110, 36);
            this.btnGoToChart.TabIndex = 6;
            this.btnGoToChart.Text = "График";
            this.btnGoToChart.UseVisualStyleBackColor = false;
            this.btnGoToChart.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGoToChart.ForeColor = System.Drawing.Color.White;
            this.btnGoToChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToChart.Click += new System.EventHandler(this.btnGoToChart_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(730, 150);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(110, 36);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 340);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(12, 365);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 13);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGrade.ForeColor = System.Drawing.Color.Black;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.numSorCount);
            this.Controls.Add(this.lblSorCount);
            this.Controls.Add(this.lblQuarter);
            this.Controls.Add(this.cmbQuarter);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lblSoch);
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
        private System.Windows.Forms.Label lblSoch;
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
