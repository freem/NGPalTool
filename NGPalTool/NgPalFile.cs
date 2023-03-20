using System.IO;

namespace NGPalTool
{
	/// <summary>
	/// .ngpal from blastar's NGFX.
	/// </summary>
	/// The format is pretty simple, 16 NeoColors per file.
	public class NgPalFile
	{
		/// <summary>
		/// Color entries in this .ngpal file.
		/// </summary>
		public NeoColor[] Entries;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public NgPalFile()
		{
			Entries = new NeoColor[16];
			for (int i = 0; i < Entries.Length; i++)
			{
				Entries[i] = new NeoColor();
			}
		}

		/// <summary>
		/// Constructor from a file.
		/// </summary>
		/// <param name="path">Path to .ngpal file</param>
		public NgPalFile(string path)
		{
			Entries = new NeoColor[16];
			for (int i = 0; i < Entries.Length; i++)
			{
				Entries[i] = new NeoColor();
			}
			ReadFile(path);
		}

		/// <summary>
		/// Read data from a .ngpal file.
		/// </summary>
		/// <param name="path">Path to .ngpal file</param>
		public void ReadFile(string path)
		{
			using (FileStream fs = new FileStream(path,FileMode.Open))
			{
				using (BinaryReader br = new BinaryReader(fs))
				{
					for (int i = 0; i < Entries.Length; i++)
					{
						byte v1 = br.ReadByte();
						byte v2 = br.ReadByte();

						ushort temp = (ushort)(((v1 & 0xFF) << 8)|(v2 & 0xFF));
						Entries[i].FromHex(temp);
					}
				}
			}
		}

		/// <summary>
		/// Write data to a .ngpal file.
		/// </summary>
		/// <param name="path">Path to .ngpal file</param>
		public void WriteFile(string path)
		{
			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				using (BinaryWriter br = new BinaryWriter(fs))
				{
					for (int i = 0; i < Entries.Length; i++)
					{
						ushort outVal = Entries[i].ToHex();
						br.Write((byte)((outVal&0xFF00)>>8));
						br.Write((byte)(outVal&0x00FF));
					}
				}
			}
		}
	}
}
