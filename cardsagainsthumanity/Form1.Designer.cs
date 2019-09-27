namespace cardsagainsthumanity {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.titleLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.titleLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
			this.titleLabel.Location = new System.Drawing.Point(310, 15);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(580, 58);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Cards Against Humanity";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(310, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(580, 220);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1309, 661);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.titleLabel);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Cards Against Humanity";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Button button1;
	}
}

