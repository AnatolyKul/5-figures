using System;

namespace ConsoleApp13
{
	
		class Program
		{
		    static void Main(string[] args)
			{
			   Figures [] t = new Figures[5];
			   t[0] = new Square("Квадрат", "4", "4", "360°", "S=a^2");
			   t[1] = new A_circle("Круг", "0", "0", "360°", "S=nR^2");
			   t[2] = new Triangle("Треугольник", "3", "3", "180°", "S=1/2*a*h");
			   t[3] = new Rhombus("Ромб", "4", "4", "360°", "S=a*h");
			   t[4] = new Star("Звезда", "10", "10", "180°", "S=LR2");

			 foreach (Figures a in t)
			  {
				a.name();
				a.parties();
				a.corners();
				a.degree();
				a.area();
				Console.WriteLine("");
			 }
			
			   Console.ReadKey();
			   
			







		    } 
		}
}
