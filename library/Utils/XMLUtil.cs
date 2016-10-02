using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using avmOP.DLL.Exceptions;

namespace avmOP.DLL.Utils
{
	public static class XMLUtil
	{
		/// <summary>
		/// var conf = XMLUtil.ReadXML<Configuration>("config.xml");
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="p_File"></param>
		/// <returns></returns>
		public static T ReadXML<T>(string p_File)
		{
			try
			{
				T returnedXmlClass = default(T);
				using(var reader = new XmlTextReader(p_File))
				{
					returnedXmlClass = (T)new XmlSerializer(typeof(T)).Deserialize(reader);
				}
				return returnedXmlClass;
			}
			catch(Exception ex)
			{
				throw ExceptionFactory.GetException(ex);
			}
		}

		/// <summary>
		/// conf.WriteXML("config.xml");
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="p_Object"></param>
		/// <param name="p_File"></param>
		public static void WriteXML<T>(this T p_Object, string p_File)
		{
			try
			{
				var serializer = new XmlSerializer(typeof(T));
				using(var writer = new StreamWriter(p_File, false, Encoding.UTF8))
				{
					serializer.Serialize(writer, p_Object);
				}
			}
			catch(Exception ex)
			{
				throw ExceptionFactory.GetException(ex);
			}
		}
	}
}
