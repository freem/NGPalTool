using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

#if !WITHOUT_ICON_CHANGE
using System.Runtime.InteropServices; // xxx: probable portability issue
#endif

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NGPalTool
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// what if I don't *want* to trigger something three times every time
		/// someone wants to change the color via the browse button?
		/// </summary>
		protected bool ColorMultiChange = false;

		/// <summary>
		/// Set to true when changing the name from non-typing actions
		/// </summary>
		protected bool ExternalNameChange = false;

		/// <summary>
		/// Currently active color.
		/// </summary>
		protected NeoColor CurNeoColor;

		/// <summary>
		/// Loaded palette sets
		/// </summary>
		protected Dictionary<int, NeoPalFileEntry> PaletteSets;

		/// <summary>
		/// Current palette set displayed as a Bitmap.
		/// </summary>
		protected Bitmap PalSetDisplay;

#if !WITHOUT_ICON_CHANGE
		/// <summary>
		/// Current palette set displayed as an icon
		/// </summary>
		protected Bitmap IconDisplay;

		/// <summary>
		/// Thing that makes portability a pain in the ass.
		/// </summary>
		protected IntPtr DynamicFormIcon;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		extern static bool DestroyIcon(IntPtr handle);
#endif

		#region Dialogs
		public Dialogs.ExportRangeASM ExportRangeAsmDialog;
		public Dialogs.AboutBox ProgAboutBox;
		#endregion

		#region File Dialog Filters
		/// <summary>
		/// Filters for NeoPal and NGFX NGPal files.
		/// </summary>
		public const string FileFilters_MultiPal = "All Supported Formats (*.neopal;*.ngpal)|*.neopal;*.ngpal|NeoPal Files (*.neopal)|*.neopal|NGFX NGPal Files (*.ngpal)|*.ngpal|All Files (*.*)|*.*";

		/// <summary>
		/// Filters for JASC Paint Shop Pro format palette files
		/// </summary>
		public const string FileFilters_PalJASC = "Paint Shop Pro Palette Files (*.pal)|*.pal|All Files (*.*)|*.*";

		/// <summary>
		/// Filters for PNG files
		/// </summary>
		public const string FileFilters_PNG = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";

		/// <summary>
		/// Filters for assembly export
		/// </summary>
		public const string FileFilters_ASM = "Assembly Language Files (*.inc;*.asm;*.s)|*.inc;*.asm;*.s|All Files (*.*)|*.*";
		#endregion

		public MainForm()
		{
			InitializeComponent();
			CurNeoColor = new NeoColor(0, 0, 0, false);
			ColorMultiChange = false;
			ExternalNameChange = false;
			ConvertColor();

			PaletteSets = new Dictionary<int, NeoPalFileEntry>(256);
			for (int i = 0; i < 256; i++)
			{
				PaletteSets[i] = new NeoPalFileEntry(String.Format("Palette{0:X2}",i));
				for (int j = 0; j < PaletteSets[i].Colors.Length; j++)
				{
					PaletteSets[i].Colors[j] = new NeoColor();
				}
			}

			PalSetDisplay = new Bitmap(pbPalettePreview.Width, pbPalettePreview.Height);
			UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
			IconDisplay = new Bitmap(16, 16);
			UpdateIcon();
#endif
			UpdateName();
		}

		/// <summary>
		/// The actual heavy lifting portion
		/// </summary>
		public void ConvertColor()
		{
			CurNeoColor.FromRGB((int)nudInRed.Value, (int)nudInGreen.Value, (int)nudInBlue.Value);
			Color outRGBColor = CurNeoColor.ToColor();

			tbOutRed.Text = String.Format("${0:X2}{2} ({1})", CurNeoColor.Red, outRGBColor.R, CurNeoColor.DarkBit ? "'" : "");
			tbOutGreen.Text = String.Format("${0:X2}{2} ({1})", CurNeoColor.Green, outRGBColor.G, CurNeoColor.DarkBit ? "'" : "");
			tbOutBlue.Text = String.Format("${0:X2}{2} ({1})", CurNeoColor.Blue, outRGBColor.B, CurNeoColor.DarkBit ? "'" : "");
			cbDarkBit.Checked = CurNeoColor.DarkBit;
			tbOutHex.Text = String.Format("${0:X4}",CurNeoColor.ToHex());
			panelOutColorPreview.BackColor = outRGBColor;
		}

		/// <summary>
		/// Similar to ConvertColor, but without doing the FromRGB conversion
		/// </summary>
		public void UpdateColor()
		{
			int curPalSet = (int)nudPalSet.Value;
			int newIndex = (int)nudPalIndex.Value;
			CurNeoColor = PaletteSets[curPalSet].Colors[newIndex];
			Color display = CurNeoColor.ToColor();

			ColorMultiChange = true;
			nudInRed.Value = display.R;
			nudInGreen.Value = display.G;
			nudInBlue.Value = display.B;
			cbDarkBit.Checked = CurNeoColor.DarkBit;
			ColorMultiChange = false;

			tbOutRed.Text = String.Format("${0:X2}{2} ({1})", CurNeoColor.Red, display.R, CurNeoColor.DarkBit ? "'" : "");
			tbOutGreen.Text = String.Format("${0:X2}{2} ({1})", CurNeoColor.Green, display.G, CurNeoColor.DarkBit ? "'" : "");
			tbOutBlue.Text = String.Format("${0:X2}{2} ({1})", CurNeoColor.Blue, display.B, CurNeoColor.DarkBit ? "'" : "");
			cbDarkBit.Checked = CurNeoColor.DarkBit;
			tbOutHex.Text = String.Format("${0:X4}", CurNeoColor.ToHex());
			panelOutColorPreview.BackColor = display;
		}

		/// <summary>
		/// Update the palette set preview display.
		/// </summary>
		public void UpdatePaletteSetPreview()
		{
			// 480px wide = 30px per color
			int curPalSet = (int)nudPalSet.Value;
			Graphics g = Graphics.FromImage(PalSetDisplay);
			for (int i = 0; i < 16; i++)
			{
				Color curColor = PaletteSets[curPalSet].Colors[i].ToColor();
				g.FillRectangle(new SolidBrush(curColor), i*30,0,30,pbPalettePreview.Height);
			}
			pbPalettePreview.Image = PalSetDisplay;
		}

		/// <summary>
		/// you're telling me you want to make the program icon a representation of the current palette set?
		/// </summary>
		public void UpdateIcon()
		{
#if !WITHOUT_ICON_CHANGE
			int curPalSet = (int)nudPalSet.Value;
			using (Graphics g = Graphics.FromImage(IconDisplay))
			{
				for (int i = 0; i < 16; i++)
				{
					Color curColor = PaletteSets[curPalSet].Colors[i].ToColor();
					int x = i % 4;
					int y = (int)(i / 4);
					g.FillRectangle(new SolidBrush(curColor), x * 4, y * 4, 4, 4);
				}
				DynamicFormIcon = IconDisplay.GetHicon();
			}
			Icon = Icon.FromHandle(DynamicFormIcon);
#endif
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
#if !WITHOUT_ICON_CHANGE
			DestroyIcon(DynamicFormIcon);
#endif
		}

		/// <summary>
		/// Show the regular Windows color picker, and set the color if OK.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnColorPicker_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				// wow cool, new color
				ColorMultiChange = true;
				nudInRed.Value = colorDialog1.Color.R;
				nudInGreen.Value = colorDialog1.Color.G;
				nudInBlue.Value = colorDialog1.Color.B;
				ColorMultiChange = false;
				ConvertColor();
				UpdatePaletteSetPreview();

#if !WITHOUT_ICON_CHANGE
				UpdateIcon();
#endif
			}
		}

		/// <summary>
		/// Every time you change the color value, it has to be converted again.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void nudInColor_ValueChanged(object sender, EventArgs e)
		{
			if (!ColorMultiChange)
			{
				ConvertColor();
				UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
				UpdateIcon();
#endif
			}
		}

		/// <summary>
		/// Select the text every time someone enters the color NumericUpDown,
		/// because I like to tab between values.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void nudInColor_Enter(object sender, EventArgs e)
		{
			((NumericUpDown)sender).Select(0, 3);
		}

		/// <summary>
		/// Select the text every time someone enters the output hex textbox,
		/// because it's easier to copy values that way.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbOutHex_Enter(object sender, EventArgs e)
		{
			tbOutHex.SelectAll();
		}

		private void nudPalIndex_ValueChanged(object sender, EventArgs e)
		{
			UpdateColor();
#if !WITHOUT_ICON_CHANGE
			UpdateIcon();
#endif
		}

		private void nudPalSet_ValueChanged(object sender, EventArgs e)
		{
			ExternalNameChange = true;
			UpdateColor();
			UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
			UpdateIcon();
#endif
			UpdateName();
			ExternalNameChange = false;
		}

		#region Palette Set Name-related
		/// <summary>
		/// Update the palette set name textbox.
		/// </summary>
		private void UpdateName()
		{
			int curPalSet = (int)nudPalSet.Value;
			tbPalSetName.Text = PaletteSets[curPalSet].Name;
		}

		/// <summary>
		/// Handle changing the name of a palette set.
		/// </summary>
		private void tbPalSetName_TextChanged(object sender, EventArgs e)
		{
			if (!ExternalNameChange)
			{
				if (!String.IsNullOrEmpty(tbPalSetName.Text))
				{
					PaletteSets[(int)nudPalSet.Value].Name = tbPalSetName.Text;
				}
			}
		}

		/// <summary>
		/// Check for invalid character input.
		/// </summary>
		private void tbPalSetName_KeyPress(object sender, KeyPressEventArgs e)
		{
			foreach (char c in Program.DisallowedChars)
			{
				if (e.KeyChar == c)
				{
					e.Handled = false;
					e.KeyChar = '\0';
					return;
				}
			}
		}
		#endregion

		#region File Menu
		private void newPaletteFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurNeoColor = new NeoColor(0, 0, 0, false);
			ConvertColor();
			PaletteSets = new Dictionary<int, NeoPalFileEntry>(256);
			for (int i = 0; i < 256; i++)
			{
				PaletteSets[i] = new NeoPalFileEntry(String.Format("Palette{0:X2}", i));
				for (int j = 0; j < PaletteSets[i].Colors.Length; j++)
				{
					PaletteSets[i].Colors[j] = new NeoColor();
				}
			}

			nudPalSet.Value = 0;
			nudPalIndex.Value = 0;

			UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
			UpdateIcon();
#endif
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Open Palette File";
			ofd.Filter = FileFilters_MultiPal;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				string fileExt = Path.GetExtension(ofd.FileName);
				bool forceNGPal = false;
				if (string.IsNullOrEmpty(fileExt))
				{
					MessageBox.Show("This file lacks an extension.\nAttempting to load as .ngpal format; results may vary.","NGPalTool");
					forceNGPal = true;
				}

				// what we load depends on the file extension
				if (fileExt.Equals(".ngpal") || forceNGPal)
				{
					// blastar's NGFX .ngpal
					NgPalFile tempFile = new NgPalFile(ofd.FileName);
					PaletteSets[(int)nudPalSet.Value].Colors = tempFile.Entries;
				}
				else if (fileExt.Equals(".neopal"))
				{
					// freem wants to store multiple named palettes in a file for some reason
					NeoPalFile tempFile = new NeoPalFile(ofd.FileName);
					for (int i = 0; i < PaletteSets.Count; i++)
					{
						PaletteSets[i].Colors = tempFile.Entries[i].Colors;
						PaletteSets[i].Name = tempFile.Entries[i].Name;
					}
					UpdateName();
				}
				else
				{
					// unrecognized format
					MessageBox.Show(String.Format("Unrecognized palette file extension '{0}'.", fileExt),"NGPalTool");
					return;
				}

				
				UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
				UpdateIcon();
#endif
			}
		}

		/// <summary>
		/// Save active palette set to a .ngpal file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void savePaletteFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Save Palette File";
			sfd.Filter = FileFilters_MultiPal;
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				string fileExt = Path.GetExtension(sfd.FileName);
				bool forceNGPal = false;
				if (string.IsNullOrEmpty(Path.GetExtension(sfd.FileName)))
				{
					MessageBox.Show("Output file has no extension.\nSaving as .ngpal format.","NGPalTool");
					forceNGPal = true;
				}

				// what we save depends on the file extension.
				if (fileExt.Equals(".ngpal") || forceNGPal)
				{
					// .ngpal: save the current active palette set
					NgPalFile tempFile = new NgPalFile();
					tempFile.Entries = PaletteSets[(int)nudPalSet.Value].Colors;
					tempFile.WriteFile(sfd.FileName);
				}
				else if (fileExt.Equals(".neopal"))
				{
					NeoPalFile tempFile = new NeoPalFile();
					for (int i = 0; i < PaletteSets.Count; i++)
					{
						tempFile.Entries.Add(new NeoPalFileEntry(PaletteSets[i].Name, PaletteSets[i].Colors));
					}
					tempFile.WriteFile(sfd.FileName);
				}
				else
				{
					// unrecognized format
					MessageBox.Show(String.Format("Unrecognized palette file extension '{0}'. freem needs to fix this, probably", fileExt),"NGPalTool");
					return;
				}

				
			}
		}

		/// <summary>
		/// get out of here!
		/// </summary>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		#region Navigation Menu
		private void nextIndexToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (nudPalIndex.Value < nudPalIndex.Maximum)
			{
				nudPalIndex.Value++;
			}
			else
			{
				nudPalIndex.Value = nudPalIndex.Minimum;
			}
		}

		private void previousIndexToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (nudPalIndex.Value > nudPalIndex.Minimum)
			{
				nudPalIndex.Value--;
			}
			else
			{
				nudPalIndex.Value = nudPalIndex.Maximum;
			}
		}

		private void nextSetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (nudPalSet.Value < nudPalSet.Maximum)
			{
				nudPalSet.Value++;
			}
			else
			{
				nudPalSet.Value = nudPalSet.Minimum;
			}
		}

		private void previousSetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (nudPalSet.Value > nudPalSet.Minimum)
			{
				nudPalSet.Value--;
			}
			else
			{
				nudPalSet.Value = nudPalSet.Maximum;
			}
		}
		#endregion

		#region Import/Export Helpers
		/// <summary>
		/// Convert a palette set to ASM export format.
		/// </summary>
		/// <param name="palSetNum">Palette set number, 0-255</param>
		/// <param name="sb">StringBuilder instance to use.</param>
		/// <param name="label">String to use for the label export. (optional)</param>
		protected void PalSetToASM(int palSetNum, StringBuilder sb, string label = "")
		{
			if (String.IsNullOrEmpty(label))
			{
				label = String.Format("ExportSet{0}:", palSetNum);
			}
			if (!label.EndsWith(":"))
			{
				label += ":";
			}

			sb.AppendLine(label);
			sb.Append("\tdc.w ");
			for (int i = 0; i < 8; i++)
			{
				sb.AppendFormat("${0:X4}", PaletteSets[palSetNum].Colors[i].ToHex());
				if (i < 7)
				{
					sb.Append(", ");
				}
			}
			sb.AppendLine();
			sb.Append("\tdc.w ");
			for (int i = 8; i < 16; i++)
			{
				sb.AppendFormat("${0:X4}", PaletteSets[palSetNum].Colors[i].ToHex());
				if (i < 15)
				{
					sb.Append(", ");
				}
			}
			sb.AppendLine();
		}
		#endregion

		#region Import/Export Menu
		private void importFromPNGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Open PNG File(s)";
			ofd.Filter = FileFilters_PNG;
			ofd.Multiselect = true;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (ofd.FileNames.Length > 1)
				{
					// unfortunately, the order in which the files are selected matters.
					// I'm not fond of it either, but I have to deal with it anyways.
					int numErrors = 0;
					List<string> errorFiles = new List<string>();
					bool shownLazyErrorMsg = false;
					int palSetNum = (int)nudPalSet.Value;
					for (int i = 0; i < ofd.FileNames.Length; i++)
					{
						// every png file
						string path = ofd.FileNames[i];
						Image inImage = Image.FromFile(path);
						if (inImage.PixelFormat == PixelFormat.Format4bppIndexed || inImage.PixelFormat == PixelFormat.Format8bppIndexed)
						{
							if (inImage.Palette.Entries.Length <= 16)
							{
								// standard
								for (int j = 0; j < inImage.Palette.Entries.Length; j++)
								{
									PaletteSets[palSetNum].Colors[j].FromColor(inImage.Palette.Entries[j]);
								}
								palSetNum++;
							}
							else
							{
								// likely 256
								if (!shownLazyErrorMsg)
								{
									shownLazyErrorMsg = true;
									MessageBox.Show("Importing 256 color PNG files is not supported when importing more than one file.\nYes, it's arbitrary.\nNo, I don't want to write the code to deal with it.","NGPalTool");
								}
							}
						}
						else
						{
							numErrors++;
							errorFiles.Add(path);
						}
						inImage.Dispose();
					}

					if (numErrors > 0)
					{
						StringBuilder sb = new StringBuilder();
						sb.AppendLine("The following files had problems being converted:");
						foreach (string file in errorFiles)
						{
							sb.AppendLine(file);
						}
						MessageBox.Show(sb.ToString());
					}
					UpdateColor();
					UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
					UpdateIcon();
#endif
				}
				else
				{
					// a single png
					Image inImage = Image.FromFile(ofd.FileName);
					if (inImage.PixelFormat == PixelFormat.Format4bppIndexed || inImage.PixelFormat == PixelFormat.Format8bppIndexed)
					{
						if (inImage.Palette.Entries.Length <= 16)
						{
							for (int i = 0; i < inImage.Palette.Entries.Length; i++)
							{
								PaletteSets[(int)nudPalSet.Value].Colors[i].FromColor(inImage.Palette.Entries[i]);
							}
							UpdateColor();
							UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
							UpdateIcon();
#endif
						}
						else
						{
							// 256 colors = 16 palette sets
							int palIndex = 0;
							for (int i = 0; i < 16; i++)
							{
								for (int p = 0; p < 16; p++)
								{
									PaletteSets[i].Colors[p].FromColor(inImage.Palette.Entries[palIndex + p]);
								}
								if (palIndex < 256-16)
								{
									palIndex += 16;
								}
							}

							UpdateColor();
							UpdatePaletteSetPreview();
#if !WITHOUT_ICON_CHANGE
							UpdateIcon();
#endif
						}
					}
					else
					{
						// long error message because I'm freem, and that's just what I do sometimes
						MessageBox.Show(String.Format("Pixel Format '{0}' is currently unhandled.\nIf this is a paletted image, it's likely using transparency, which .NET is not good at handling by default.\nI'm lazy and don't want to deal with implementing it right now, and this goes for every project where I need to do it. :P", inImage.PixelFormat.ToString()),"NGPalTool");
					}
					inImage.Dispose();
				}
			}
		}

		private void exportCurrentSetAsASMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Export Palette as ASM";
			sfd.Filter = FileFilters_ASM;
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
				{
					using (StreamWriter sr = new StreamWriter(fs))
					{
						StringBuilder sb = new StringBuilder();
						PalSetToASM((int)nudPalSet.Value, sb, PaletteSets[(int)nudPalSet.Value].Name);
						sr.Write(sb.ToString());
					}
				}
			}
		}

		private void exportSetRangeAsASMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ExportRangeAsmDialog == null || ExportRangeAsmDialog.IsDisposed)
			{
				ExportRangeAsmDialog = new Dialogs.ExportRangeASM();
			}

			if (ExportRangeAsmDialog.ShowDialog() == DialogResult.OK)
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Title = "Export Palette Sets as ASM";
				sfd.Filter = FileFilters_ASM;
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					StringBuilder sb = new StringBuilder();
					using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
					{
						using (StreamWriter sr = new StreamWriter(fs))
						{
							if (ExportRangeAsmDialog.RangeStart == ExportRangeAsmDialog.RangeEnd)
							{
								// only export one palette (use start value)
								PalSetToASM(ExportRangeAsmDialog.RangeStart, sb, PaletteSets[ExportRangeAsmDialog.RangeStart].Name);
								sr.Write(sb.ToString());
							}
							else
							{
								// exporting multiple palettes
								for (int i = ExportRangeAsmDialog.RangeStart; i <= ExportRangeAsmDialog.RangeEnd; i++)
								{
									PalSetToASM(i, sb, PaletteSets[i].Name);
									sb.AppendLine();
								}
								sr.Write(sb.ToString());
							}
						}
					}
				}
			}
		}
		#endregion

		#region Convert Menu
		// todo: finish implementing
		private void convertJascToNgpalToolstripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Open Paint Shop Pro Palette File";
			ofd.Filter = FileFilters_PalJASC;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				JascPalFile palFile = new JascPalFile();
				if (palFile.ReadFile(ofd.FileName))
				{
					// ok
					MessageBox.Show("Currently unimplemented, though not that hard to code.", "NGPalTool");
				}
				else
				{
					MessageBox.Show(String.Format("Error reading file '{0}'.",ofd.FileName), "NGPalTool");
				}
			}
		}
		#endregion

		#region Help Menu
		/// <summary>
		/// This is just here for identification purposes.
		/// </summary>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ProgAboutBox == null || ProgAboutBox.IsDisposed)
			{
				ProgAboutBox = new Dialogs.AboutBox();
			}
			ProgAboutBox.ShowDialog();
		}

		/// <summary>
		/// Load the manual.
		/// </summary>
		private void manualToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\Manual\\index.html");
			
		}
		#endregion
	}
}
