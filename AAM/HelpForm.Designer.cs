namespace AAM
{
    partial class HelpForm
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
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            // Windows Media Player control requires AxWMPLib reference and will be added by developer if desired.
            this.axWMP = null;
            this.SuspendLayout();
            // 
            // rtbHelp
            // 
            this.rtbHelp.Location = new System.Drawing.Point(12, 12);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.Size = new System.Drawing.Size(400, 200);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 220);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 30);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // axWMP
            // 
            // AxWindowsMediaPlayer not initialized in code. To enable video player, add COM component reference via Toolbox.
            // 
            // HelpForm
            // 
            this.ClientSize = new System.Drawing.Size(740, 260);
            this.Controls.Add(this.rtbHelp);
            this.Controls.Add(this.btnPlay);
            this.Name = "HelpForm";
            this.Text = "Справка";
            // axWMP EndInit skipped
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.Button btnPlay;
        private object axWMP;
    }
}
