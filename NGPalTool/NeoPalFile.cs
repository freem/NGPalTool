using System;
using System.Collections.Generic;
using System.IO;

namespace NGPalTool
{
	/// <summary>
	/// A single entry in the NeoPalFile.
	/// </summary>
	public class NeoPalFileEntry
	{
		#region Struct Members
		/// <summary>
		/// Name assigned to this palette set.
		/// </summary>
		/// Characters in Program.DisallowedChars are not allowed.
		public string Name;

		/// <summary>
		/// Colors in this palette set.
		/// </summary>
		public NeoColor[] Colors;
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		public NeoPalFileEntry()
		{
			Name = "unnamed";
			Colors = new NeoColor[16];
			for (int i = 0; i < Colors.Length; i++)
			{
				Colors[i] = new NeoColor();
			}
		}

		/// <summary>
		/// Named constructor.
		/// </summary>
		/// <param name="name">Name of this NeoPalFileEntry.</param>
		public NeoPalFileEntry(string name)
		{
			Name = name;
			Colors = new NeoColor[16];
			for (int i = 0; i < Colors.Length; i++)
			{
				Colors[i] = new NeoColor();
			}
		}

		/// <summary>
		/// Named constructor with palette colors.
		/// </summary>
		/// <param name="name">Name of this NeoPalFileEntry.</param>
		/// <param name="colors">Array of NeoColor values for this NeoPalFileEntry.</param>
		public NeoPalFileEntry(string name, NeoColor[] colors)
		{
			Name = name;
			Colors = colors;
		}
		#endregion

		/// <summary>
		/// NeoPalFileEntry to string, primarily for file export.
		/// </summary>
		/// <returns>File-ready string for this palette set.</returns>
		public override string ToString()
		{
			string outStr = String.Format("{0}:",Name);

			for (int i = 0; i < Colors.Length; i++)
			{
				outStr += Colors[i].ToString();
				if (i < Colors.Length-1)
				{
					outStr += ",";
				}
			}

			return outStr;
		}

		/// <summary>
		/// NeoPalFileEntry from string, primarily for file import.
		/// </summary>
		/// <param name="input">NeoPalFileEntry input string.</param>
		/// <returns>True if conversion was successful.</returns>
		public bool FromString(string input)
		{
			// name:colors
			int colonPos = input.IndexOf(':');

			if (colonPos < 0)
			{
				// couldn't find colon
				return false;
			}

			// Sanitize name
			Name = input.Substring(0,colonPos);
			foreach (char invalidChar in Program.DisallowedChars)
			{
				Name = Name.Replace(invalidChar.ToString(), String.Empty);
			}

			string[] colorStrings = input.Substring(colonPos + 1).Split(',');
			for (int i = 0; i < colorStrings.Length; i++)
			{
				Colors[i].FromString(colorStrings[i]);
			}
			return true;
		}
	}

	/// <summary>
	/// "Neo(-Geo) Palette File"
	/// </summary>
	/// This format is plain text, and allows for saving multiple palette sets to a single file.
	public class NeoPalFile
	{
		/// <summary>
		/// List of entries in this NeoPalFile.
		/// </summary>
		public List<NeoPalFileEntry> Entries;

		#region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		public NeoPalFile()
		{
			Entries = new List<NeoPalFileEntry>();
		}

		/// <summary>
		/// Constructor from a file.
		/// </summary>
		/// <param name="path">Path to .neopal file</param>
		public NeoPalFile(string path)
		{
			Entries = new List<NeoPalFileEntry>();
			ReadFile(path);
		}
		#endregion

		#region File Read/Write
		/// <summary>
		/// Read NeoPalFile data.
		/// </summary>
		/// <param name="path">Path to .neopal file</param>
		public void ReadFile(string path)
		{
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				using (StreamReader sr = new StreamReader(fs))
				{
					int palSet = 0;
					while (!sr.EndOfStream)
					{
						Entries.Add(new NeoPalFileEntry());
						Entries[palSet].FromString(sr.ReadLine());
						palSet++;
					}
				}
			}
		}

		/// <summary>
		/// Write NeoPalFile data.
		/// </summary>
		/// <param name="path">Output filename.</param>
		public void WriteFile(string path)
		{
			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				using (StreamWriter sw = new StreamWriter(fs))
				{
					foreach (NeoPalFileEntry entry in Entries)
					{
						sw.WriteLine(entry.ToString());
					}
				}
			}
		}
		#endregion
	}
}
