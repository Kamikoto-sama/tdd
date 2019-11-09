﻿﻿using System;
using System.Drawing;

namespace TagsCloudVisualization
{
	public static class RectangleExtensions
	{
		public static int GetBottom(this Rectangle rectangle) => rectangle.Y - rectangle.Height;

		public static PointF GetCenter(this Rectangle rectangle)
		{
			var centerX = rectangle.X + rectangle.Width / 2f;
			var centerY = rectangle.Y - rectangle.Height / 2f;
			return new PointF(centerX, centerY);
		}
	}
}