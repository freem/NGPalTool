using System;
using System.Drawing;

namespace NGPalTool
{
	/// <summary>
	/// Neo-Geo color.
	/// </summary>
	public class NeoColor
	{
		/// <summary>
		/// Red value (0-31)
		/// </summary>
		public byte Red;

		/// <summary>
		/// Green value (0-31)
		/// </summary>
		public byte Green;

		/// <summary>
		/// Blue value (0-31)
		/// </summary>
		public byte Blue;

		/// <summary>
		/// Dark bit (RGB-1 if set)
		/// </summary>
		public bool DarkBit;

		#region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		public NeoColor()
		{
			Red = 0;
			Green = 0;
			Blue = 0;
			DarkBit = false;
		}

		/// <summary>
		/// Standard RGB constructor.
		/// </summary>
		/// <param name="r">Red value (0-31)</param>
		/// <param name="g">Green value (0-31)</param>
		/// <param name="b">Blue value (0-31)</param>
		public NeoColor(int r, int g, int b)
		{
			Red = (byte)r;
			Green = (byte)g;
			Blue = (byte)b;
			DarkBit = false;
		}

		/// <summary>
		/// RGB and Dark Bit constructor.
		/// </summary>
		/// <param name="r">Red value (0-31)</param>
		/// <param name="g">Green value (0-31)</param>
		/// <param name="b">Blue value (0-31)</param>
		/// <param name="d">Dark bit (RGB-1)</param>
		public NeoColor(int r, int g, int b, bool d)
		{
			Red = (byte)r;
			Green = (byte)g;
			Blue = (byte)b;
			DarkBit = d;
		}

		/// <summary>
		/// Constructor from Neo-Geo color format data.
		/// </summary>
		/// <param name="inHex">Neo-Geo color value.</param>
		public NeoColor(ushort inHex)
		{
			FromHex(inHex);
		}
		#endregion

		/// <summary>
		/// Convert a color to Neo-Geo hex value.
		/// </summary>
		/// <returns>Neo-Geo color value.</returns>
		public ushort ToHex()
		{
			ushort outColor = 0;

			// FEDCBA9876543210
			// DrgbRRRRGGGGBBBB
			// ||||||||||||||||
			// ||||||||||||++++-- Blue 4321
			// ||||||||++++------ Green 4321
			// ||||++++---------- Red 4321
			// |+++-------------- least significant bits (0)
			// +----------------- Dark bit

			if (DarkBit)
			{
				outColor |= 0x8000;
			}

			// RGB LSB
			outColor |= (ushort)(((Red & 1) << 14) | ((Green & 1) << 13) | ((Blue & 1) << 12));

			// the remaining RGB bits
			outColor |= (ushort)(((Red & 0x1E) << 7) | ((Green & 0x1E) << 3) | (Blue >> 1));

			return outColor;
		}

		/// <summary>
		/// Get NeoColor as a hardware-ready hex value in a string.
		/// </summary>
		/// <returns>String with the hex value of this color.</returns>
		public override string ToString()
		{
			return String.Format("{0:X4}",ToHex());
		}

		/// <summary>
		/// Convert a Neo-Geo hex color.
		/// </summary>
		/// <param name="inHex">input Neo-Geo color</param>
		public void FromHex(ushort inHex)
		{
			// FEDCBA9876543210
			// DrgbRRRRGGGGBBBB
			// ||||||||||||||||
			// ||||||||||||++++-- Blue 4321
			// ||||||||++++------ Green 4321
			// ||||++++---------- Red 4321
			// |+++-------------- least significant bits (0)
			// +----------------- Dark bit

			if ((inHex & 0x8000) != 0)
			{
				DarkBit = true;
			}

			Red = (byte)((inHex & 0x4000) >> 14 | (inHex & 0x0F00) >> 7);
			Green = (byte)((inHex & 0x2000) >> 13 | (inHex & 0x00F0) >> 3);
			Blue = (byte)((inHex & 0x1000) >> 12 | (inHex & 0x000F) << 1);
		}

		public void FromString(string inHex)
		{
			FromHex(Convert.ToUInt16(inHex, 16));
		}

		#region RGB color-related
		/// <summary>
		/// Convert from RGB 0-255 to RGB 0-31+Dark bit.
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public void FromRGB(int r, int g, int b)
		{
			Red = (byte)Math.Floor((decimal)r / 8);
			Green = (byte)Math.Floor((decimal)g / 8);
			Blue = (byte)Math.Floor((decimal)b / 8);
			DarkBit = ((int)Math.Floor((54.213f * r) + (182.376f * g) + (18.411f * b)) & 1) == 1 ? true : false;
		}

		/// <summary>
		/// Convert from internal RGB 0-31+Dark bit representation to System.Drawing.Color.
		/// </summary>
		/// <returns>Color converted to RGB 0-255</returns>
		public Color ToColor()
		{
			int luma = DarkBit ? 0 : 1;
			int rgbOutRed = (((Red << 1) + luma) << 2);
			int rgbOutGreen = (((Green << 1) + luma) << 2);
			int rgbOutBlue = (((Blue << 1) + luma) << 2);
			return Color.FromArgb(rgbOutRed, rgbOutGreen, rgbOutBlue);
		}

		/// <summary>
		/// C# Color convienence function.
		/// </summary>
		/// <param name="inColor">Color to convert</param>
		public void FromColor(Color inColor)
		{
			FromRGB(inColor.R, inColor.G, inColor.B);
		}
		#endregion
	}
}
