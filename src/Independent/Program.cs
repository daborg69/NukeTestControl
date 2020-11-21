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

			int y = 0;
			string name = "Bob Jones";

			string test = string.Format("add -m \" this is the text message for {0} with value {1} \"", name, y);
            Console.WriteLine(test);

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
