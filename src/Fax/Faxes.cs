using System;

namespace Daborg69.Fax
{
	public class Faxes
	{
		public Faxes (int n) {
			NumberOfFaxes = n;

		}


		public int NumberOfFaxes { get; set; }

		public string FaxNumber { get; set; }
	}
}
