using System;
using System.IO;
using System.Text.Json;
using Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Independent
{
	class Program
	{
		static void Main(string[] args)
		{
			GetSemVerSorted();
		}


		static void GetSemVerSorted () {
			{
				List<string> input = new List<string>()
				{
					"0.0.2",
					"2.5.6",
					"0.0.1",
					"2.5.6-alpha.2",
					"1.0.3-feature12",
					"1.0.0",
					"5.4.0",
					"2.5.6-beta.5",
					"2.5.6-release40",
					"2.5.6-alpha5004",
					"1.4.3-alpha4",
					"2.5.6",
					"1.0.0-alpha1"
				};
				
		//		FileInfo fil = new FileInfo(@"C:\temp\semver.txt");

				Regex rgx = new Regex(@"\b\d{1,10}\.\d{1,10}\.\d{1,10}[+|-]?[0-9a-zA-Z]{1,40}?\b");
				List<string> strList = input;
				//List<string> strList = (fil.Exists) ? File.ReadAllLines(fil.FullName).ToList() : new List<string>();

				strList.RemoveAll(x => !rgx.IsMatch(x));
				var strListSorted = strList.OrderBy(x => Convert.ToInt32(x.Split('.')[0]))
				                           .ThenBy(x => Convert.ToInt32(x.Split('.')[1]))
				                           .ThenBy(x => Convert.ToInt32(x.Split('.')[2].Split('+')[0].Split('-')[0]))
				                           .ThenByDescending(x => x.Split('+')[0].ToString().Length);
				foreach ( string item in strListSorted ) {
					Console.WriteLine(item);
				}
				//File.WriteAllLines(Path.Combine(fil.Directory.FullName, "VersioningOutput.txt"), strList.ToArray());
			}
        }
	}
}
