using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGPalTool
{
	static class Program
	{
		/// <summary>
		/// Characters that can't be used for palette set label names.
		/// </summary>
		/// Technically, the '.' can be used in some names, depending on the assembler used.
		public static readonly char[] DisallowedChars = new char[]{
			' ', '.', ',', ':', ';', '?', '!', '<', '>', '(', ')', '[', ']', '{', '}', '\\', '/', '|', '-', '+', '=', '$', '#', '%', '^', '&', '@', '*'
		};

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
