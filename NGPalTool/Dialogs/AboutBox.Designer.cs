
namespace NGPalTool.Dialogs
{
	partial class AboutBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			this.lblMain = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.tbWords = new System.Windows.Forms.TextBox();
			this.linkLabelAJWorld = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// lblMain
			// 
			this.lblMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMain.Location = new System.Drawing.Point(15, 9);
			this.lblMain.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lblMain.MaximumSize = new System.Drawing.Size(320, 24);
			this.lblMain.MinimumSize = new System.Drawing.Size(128, 24);
			this.lblMain.Name = "lblMain";
			this.lblMain.Size = new System.Drawing.Size(317, 24);
			this.lblMain.TabIndex = 26;
			this.lblMain.Text = "Product Name";
			this.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(257, 182);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 29;
			this.okButton.Text = "&OK";
			// 
			// lblAuthor
			// 
			this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAuthor.Location = new System.Drawing.Point(12, 33);
			this.lblAuthor.MaximumSize = new System.Drawing.Size(320, 17);
			this.lblAuthor.MinimumSize = new System.Drawing.Size(128, 17);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(320, 17);
			this.lblAuthor.TabIndex = 30;
			this.lblAuthor.Text = "Created by freem";
			this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbWords
			// 
			this.tbWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbWords.Location = new System.Drawing.Point(12, 53);
			this.tbWords.Multiline = true;
			this.tbWords.Name = "tbWords";
			this.tbWords.ReadOnly = true;
			this.tbWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbWords.Size = new System.Drawing.Size(320, 123);
			this.tbWords.TabIndex = 31;
			this.tbWords.Text = resources.GetString("tbWords.Text");
			// 
			// linkLabelAJWorld
			// 
			this.linkLabelAJWorld.AutoSize = true;
			this.linkLabelAJWorld.Location = new System.Drawing.Point(12, 187);
			this.linkLabelAJWorld.Name = "linkLabelAJWorld";
			this.linkLabelAJWorld.Size = new System.Drawing.Size(158, 13);
			this.linkLabelAJWorld.TabIndex = 32;
			this.linkLabelAJWorld.TabStop = true;
			this.linkLabelAJWorld.Text = "https://ajworld.net/neogeodev/";
			this.linkLabelAJWorld.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAJWorld_LinkClicked);
			// 
			// AboutBox
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.okButton;
			this.ClientSize = new System.Drawing.Size(344, 217);
			this.Controls.Add(this.linkLabelAJWorld);
			this.Controls.Add(this.tbWords);
			this.Controls.Add(this.lblAuthor);
			this.Controls.Add(this.lblMain);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "only people who are poking around can see this string";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMain;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.TextBox tbWords;
		private System.Windows.Forms.LinkLabel linkLabelAJWorld;
	}
}
