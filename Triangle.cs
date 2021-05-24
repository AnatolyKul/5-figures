using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
	class Triangle : Figures
	{
		public Triangle(string name, string parties, string corners, string degree, string area) : base(name, parties, corners, degree, area)
		{
		}
		public void A()
		{
			Console.WriteLine(Name + " " + Parties + " " + Corners + " " + Degree + " " + Area);
		}
		public override void name()
		{
			base.name();
		}
		public override void parties()
		{
			base.parties();
		}
		public override void corners()
		{
			base.corners();
		}
		public override void degree()
		{
			base.degree();
		}
		public override void area()
		{
			base.area();
		}


	}
}
