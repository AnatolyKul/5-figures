using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
	class Figures
	{
		protected string Name;
		protected string Parties;
		protected string Corners;
		protected string Degree;
		protected string Area;
		

		public Figures(string name, string parties, string corners, string degree, string area)
		{
			Name = name;
			Parties = parties;
			Corners = corners;
			Degree = degree;
			Area = area;




		}
		public virtual void name()
		{
			Console.WriteLine(Name);
		}
		public virtual void parties()
		{
			Console.WriteLine(Parties);
		}
		public virtual void corners()
		{
			Console.WriteLine(Corners);
		}
		public virtual void degree()
		{
			Console.WriteLine(Degree);
		}
		public virtual void area()
		{
			Console.WriteLine(Area);
		}
		










	}
	

}


