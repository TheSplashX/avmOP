namespace avmOP
{
	partial class MovieListUC
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblMovieName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblMovieName
			// 
			this.lblMovieName.AutoSize = true;
			this.lblMovieName.Location = new System.Drawing.Point(3, 13);
			this.lblMovieName.Name = "lblMovieName";
			this.lblMovieName.Size = new System.Drawing.Size(74, 13);
			this.lblMovieName.TabIndex = 0;
			this.lblMovieName.Text = "lblMovieName";
			// 
			// MovieListUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.lblMovieName);
			this.Name = "MovieListUC";
			this.Size = new System.Drawing.Size(214, 41);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMovieName;
	}
}
