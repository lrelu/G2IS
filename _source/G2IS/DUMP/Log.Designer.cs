namespace DUMP
{
	partial class Log
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
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.SystemColors.InfoText;
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.ForeColor = System.Drawing.SystemColors.Info;
			this.richTextBox2.Location = new System.Drawing.Point(0, 0);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(503, 742);
			this.richTextBox2.TabIndex = 1;
			this.richTextBox2.Text = "";
			// 
			// Log
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 742);
			this.Controls.Add(this.richTextBox2);
			this.Name = "Log";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Log";
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.RichTextBox richTextBox2;
	}
}