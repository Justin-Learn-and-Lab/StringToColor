using System;
using System.Collections.Generic;
using System.Drawing;

namespace StringToColor
{
	public class StringToColor
	{
		public Color Transfer(string name)
		{
			List<IColor> colors = new List<IColor>();
			colors.Add(new Red());
			colors.Add(new Green());
			colors.Add(new Blue());

			foreach (IColor item in colors)
			{
				if (item.GetType().Name.ToLower() == name.ToLower())
				{
					return item.GetColor();
				}
			}

			throw new ArgumentException("不正確的顏色名稱");
		}
	}

	interface IColor
	{
		Color GetColor();
	}

	public class Red : IColor
	{
		public Color GetColor()
		{
			return Color.FromArgb(0xFF, 0xFF, 0x00, 0x00);
		}
	}

	public class Green : IColor
	{
		public Color GetColor()
		{
			return Color.FromArgb(0xFF, 0x80, 0x80, 0x80);
		}
	}

	public class Blue : IColor
	{
		public Color GetColor()
		{
			return Color.FromArgb(0xFF, 0x00, 0x00, 0xFF);
		}
	}
}


