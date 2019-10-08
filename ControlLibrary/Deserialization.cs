using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary
{
	public partial class Deserialization : Component
	{
		public Deserialization()
		{
			InitializeComponent();
		}

		public Deserialization(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		public List<T> Deserialize<T>(string path)
		{
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<T>));
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				var deserialized = (List<T>) ser.ReadObject(fs);
				return deserialized;
			}
		}
	}
}
