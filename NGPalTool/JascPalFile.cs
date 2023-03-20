using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NGPalTool
{
	public class JascPalFile
	{
		/// <summary>
		/// Palette entries.
		/// </summary>
		/// By default, this is 16, but it can also be 256.
		public Color[] Entries;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public JascPalFile()
		{
			Entries = new Color[16];
		}

		/// <summary>
		/// Constructor using an existing file.
		/// </summary>
		/// <param name="path">Path to JASC PSP Palette file to load.</param>
		public JascPalFile(string path)
		{
			Entries = new Color[16];
			ReadFile(path);
		}

		/// <summary>
		/// Read JASC PSP Palette data.
		/// </summary>
		/// <param name="path">Path to JASC PSP Palette file to load.</param>
		/// <returns>True if successful, false otherwise.</returns>
		public bool ReadFile(string path)
		{
			using (FileStream fs = new FileStream(path,FileMode.Open))
			{
				using (StreamReader sr = new StreamReader(fs))
				{
					// "JASC-PAL"
					if (sr.ReadLine().StartsWith("JASC-PAL"))
					{
						// "0100"
						if (sr.ReadLine().StartsWith("0100"))
						{
							// number of colors
							int numColors = int.Parse(sr.ReadLine());
							Entries = new Color[numColors];

							// the colors
							for (int i = 0; i < numColors; i++)
							{
								string colorLine = sr.ReadLine();
								if (!String.IsNullOrEmpty(colorLine))
								{
									// r g b
									string[] values = colorLine.Split(' ');
									int r = Math.Min(255, int.Parse(values[0]));
									int g = Math.Min(255, int.Parse(values[1]));
									int b = Math.Min(255, int.Parse(values[2]));
									Entries[i] = Color.FromArgb(r, g, b);
								}
							}
						}
						else
						{
							// no "0100" found
							return false;
						}
					}
					else
					{
						// no "JASC-PAL" found
						return false;
					}
				}
			}
			return true;
		}
	}
}
