using System;
using System.IO;
using System.Text.Json;
using Printer;

namespace Independent
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("");
			string json = @"{
  ""DeployRoot"": ""c:\\temp\\deployroot"",
  ""Projects"": [
    {
      ""Name"": ""CoreLib"",
      ""Deploy"": ""nuget""
    },
    {
      ""Name"": ""Printer"",
      ""Deploy"": ""nuget""
    },
    {
      ""Name"": ""Independent"",
      ""Deploy"": ""copy""
    },
    {
      ""Name"": ""TestLibraries"",
      ""Deploy"": ""none""
    }
  ]
}";
			Simple simple = JsonSerializer.Deserialize<Simple>(json, Simple.SerializerOptions());
			//using (FileStream fs = File.OpenRead(@"C:\temp\NukeSolutionBuild.Conf")) { Simple simple = await JsonSerializer.DeserializeAsync<Simple>(fs); }
		}
	}
}
