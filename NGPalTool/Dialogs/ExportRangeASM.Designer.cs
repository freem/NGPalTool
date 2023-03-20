
namespace NGPalTool.Dialogs
{
	partial class ExportRangeASM
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblRangeStart = new System.Windows.Forms.Label();
			this.lblRangeEnd = new System.Windows.Forms.Label();
			this.nudRangeStart = new System.Windows.Forms.NumericUpDown();
			this.nudRangeEnd = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRangeStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRangeEnd)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(12, 86);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(105, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(123, 86);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(105, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
			this.tableLayoutPanel1.Controls.Add(this.lblRangeStart, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblRangeEnd, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.nudRangeStart, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.nudRangeEnd, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 68);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// lblRangeStart
			// 
			this.lblRangeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRangeStart.AutoSize = true;
			this.lblRangeStart.Location = new System.Drawing.Point(3, 10);
			this.lblRangeStart.Name = "lblRangeStart";
			this.lblRangeStart.Size = new System.Drawing.Size(65, 13);
			this.lblRangeStart.TabIndex = 0;
			this.lblRangeStart.Text = "Range &Start";
			// 
			// lblRangeEnd
			// 
			this.lblRangeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRangeEnd.AutoSize = true;
			this.lblRangeEnd.Location = new System.Drawing.Point(3, 44);
			this.lblRangeEnd.Name = "lblRangeEnd";
			this.lblRangeEnd.Size = new System.Drawing.Size(65, 13);
			this.lblRangeEnd.TabIndex = 2;
			this.lblRangeEnd.Text = "Range &End";
			// 
			// nudRangeStart
			// 
			this.nudRangeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudRangeStart.Location = new System.Drawing.Point(74, 7);
			this.nudRangeStart.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudRangeStart.Name = "nudRangeStart";
			this.nudRangeStart.Size = new System.Drawing.Size(139, 20);
			this.nudRangeStart.TabIndex = 1;
			// 
			// nudRangeEnd
			// 
			this.nudRangeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudRangeEnd.Location = new System.Drawing.Point(74, 41);
			this.nudRangeEnd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudRangeEnd.Name = "nudRangeEnd";
			this.nudRangeEnd.Size = new System.Drawing.Size(139, 20);
			this.nudRangeEnd.TabIndex = 3;
			// 
			// ExportRangeASM
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(240, 121);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExportRangeASM";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Export Set Range as ASM";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRangeStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRangeEnd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblRangeStart;
		private System.Windows.Forms.Label lblRangeEnd;
		private System.Windows.Forms.NumericUpDown nudRangeStart;
		private System.Windows.Forms.NumericUpDown nudRangeEnd;
	}
}