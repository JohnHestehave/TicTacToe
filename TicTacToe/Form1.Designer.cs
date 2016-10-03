namespace TicTacToe
{
    partial class Form1
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.eButton = new System.Windows.Forms.Button();
			this.aButton = new System.Windows.Forms.Button();
			this.rButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 500);
			this.panel1.TabIndex = 0;
			this.panel1.Click += new System.EventHandler(this.panel1_Click);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkRed;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.eButton);
			this.panel2.Controls.Add(this.aButton);
			this.panel2.Controls.Add(this.rButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 500);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(500, 100);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(117, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "text";
			// 
			// eButton
			// 
			this.eButton.Location = new System.Drawing.Point(396, 59);
			this.eButton.Name = "eButton";
			this.eButton.Size = new System.Drawing.Size(92, 29);
			this.eButton.TabIndex = 2;
			this.eButton.Text = "Exit";
			this.eButton.UseVisualStyleBackColor = true;
			this.eButton.Click += new System.EventHandler(this.eButton_Click);
			// 
			// aButton
			// 
			this.aButton.Location = new System.Drawing.Point(298, 59);
			this.aButton.Name = "aButton";
			this.aButton.Size = new System.Drawing.Size(92, 29);
			this.aButton.TabIndex = 1;
			this.aButton.Text = "About";
			this.aButton.UseVisualStyleBackColor = true;
			this.aButton.Click += new System.EventHandler(this.aButton_Click);
			// 
			// rButton
			// 
			this.rButton.Location = new System.Drawing.Point(12, 6);
			this.rButton.Name = "rButton";
			this.rButton.Size = new System.Drawing.Size(99, 82);
			this.rButton.TabIndex = 0;
			this.rButton.Text = "Restart";
			this.rButton.UseVisualStyleBackColor = true;
			this.rButton.Click += new System.EventHandler(this.rButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 600);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(516, 639);
			this.MinimumSize = new System.Drawing.Size(516, 639);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic-Tac-Toe";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button eButton;
		private System.Windows.Forms.Button aButton;
		private System.Windows.Forms.Button rButton;
	}
}

