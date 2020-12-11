using System;
using System.Diagnostics.CodeAnalysis;


namespace Daborg69.Utility
{
	// Example of how to exclude a class (could be method also) from code coverage.
	[ExcludeFromCodeCoverage]
	public class Printer
	{
		public Printer () {
			Console.WriteLine("Printing...");
			Console.WriteLine("Still Printing");
			Console.WriteLine("Still Printing...");
			Console.WriteLine("Still Printing...");
			Console.WriteLine("Still Printing...");
			Console.WriteLine("Out  of  Ink!");
			Console.WriteLine("Ink Replaced!");
			Console.WriteLine("Continuing to Print...");
			Console.WriteLine("Still Printing...");
			Console.WriteLine("Still Printing...");
			Console.WriteLine("Still Printing...");
		}
	}
}
