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
			this.whiteCardBox = new System.Windows.Forms.RichTextBox();
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
			// whiteCardBox
			// 
			this.whiteCardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.whiteCardBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.whiteCardBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
			this.whiteCardBox.Location = new System.Drawing.Point(15, 425);
			this.whiteCardBox.Name = "whiteCardBox";
			this.whiteCardBox.ReadOnly = true;
			this.whiteCardBox.Size = new System.Drawing.Size(170, 220);
			this.whiteCardBox.TabIndex = 1;
			this.whiteCardBox.Text = "This is my test text how much can fit at this size";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1184, 661);
			this.Controls.Add(this.whiteCardBox);
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
		private System.Windows.Forms.RichTextBox whiteCardBox;
	}
}

