using System;
using System.Collections.Generic;
using System.Xml;
using MovieScrapper.DLL.Exceptions;
using MovieScrapper.DLL.Models.App;

namespace MovieScrapper.DLL.Utils
{
	public class XMLReader
	{
		public static List<XMLKeyValue> ReadXML(string p_File)
		{
			try
			{
				var list = new List<XMLKeyValue>();
				using(var reader = new XmlTextReader(p_File))
				{
					var key = "";
					var value = "";
					while(reader.Read())
					{					
						switch(reader.NodeType)
						{
							case XmlNodeType.Element:
								key = reader.Name;
								break;
							case XmlNodeType.Text:
								value = reader.Value;
								break;
							case XmlNodeType.EndElement: 
								if (reader.Name == key)
								{
									list.Add(new XMLKeyValue(key,value));
								}
								break;
						}
					}
				}
				return list;
			}
			catch(Exception ex)
			{
				throw ExceptionFactory.GetException(ex);
			}
		}
	}
}
