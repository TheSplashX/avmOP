using System.Collections.Generic;
using System.Xml.Serialization;

namespace avmOP
{
	[XmlRoot("configuration")]
	public class Configuration
	{
		[XmlElement("videofolder")]
		public List<string> VideoFolders;

		[XmlElement("audiofolder")]
		public List<string> AudioFolders;

		public Configuration()
		{

		}

		public Configuration(string p_ConfigFile)
		{

		}
	}
}
