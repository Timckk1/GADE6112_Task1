
namespace GADE6112_RTS_Game
{
    partial class frmPlayerStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlayerStats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlayerStats
            // 
            this.txtPlayerStats.Location = new System.Drawing.Point(-3, -2);
            this.txtPlayerStats.Multiline = true;
            this.txtPlayerStats.Name = "txtPlayerStats";
            this.txtPlayerStats.Size = new System.Drawing.Size(280, 366);
            this.txtPlayerStats.TabIndex = 0;
            // 
            // frmPlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 362);
            this.Controls.Add(this.txtPlayerStats);
            this.Name = "frmPlayerStats";
            this.Text = "frmPlayerStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerStats;
    }
}