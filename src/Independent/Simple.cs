using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Printer
{

	public enum SimpleEnum
	{
		None = 0,
		Nuget = 1,
		Copy = 2
	}


	public class Simple
	{
		public string DeployRoot { get; set; }

		public List<Item> Projects { get; set; }


		public Simple()
		{
			Projects = new List<Item>();
			int y = 0;
			y++;
		}

		/// <summary>
		/// Returns the project with the given name
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Item GetProjectByName(string name) { return Projects.FirstOrDefault(project => project.Name == name); }


		public static JsonSerializerOptions SerializerOptions()
		{
			JsonSerializerOptions options = new JsonSerializerOptions();
			options.Converters.Add(new JsonStringEnumConverter());
			options.WriteIndented = true;
			return options;
		}


		public string Serialize()
		{
			return JsonSerializer.Serialize(this,SerializerOptions());
		}


		public static Simple Deserialize(string json)
		{
			return JsonSerializer.Deserialize<Simple>(json, SerializerOptions());
		}
	}


	public class Item
	{
		public string Name { get; set; }

		public SimpleEnum Deploy { get; set; }
	}
}