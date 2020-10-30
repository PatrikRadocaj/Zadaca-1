using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca1
{
	public class Episode
	{
		private int ViewerCount = 0;
		private double AverageScore = 0;
		private double MaxScore = 0;
		public Episode(int a, double b, double c) { ViewerCount = a; AverageScore = b; MaxScore = c; }
		public Episode() { ViewerCount = 0; AverageScore = 0; MaxScore = 0; }
		public void AddView(double rating) { ViewerCount += 1; AverageScore += rating; if (MaxScore < rating) { MaxScore = rating; } }
		public double GetMaxScore() { return MaxScore; }
		public double GetAverageScore() { return AverageScore; }
		public int GetViewerCount() { return ViewerCount; }

	}
}
