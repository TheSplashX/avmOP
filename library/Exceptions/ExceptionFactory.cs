using System;
using System.IO;
using System.Xml;

namespace avmOP.DLL.Exceptions
{
	public static class ExceptionFactory
	{
		public static Exception GetException(Exception exception)
		{
			var message = exception.ToString();
			if(exception is FileNotFoundException)
			{
				var completePath = ((FileNotFoundException)exception).FileName;
				var folder = Path.GetDirectoryName(completePath);
				var filename = Path.GetFileName(completePath);
				message = filename + " has not been found in folder\n" + folder;
			}
			else if(exception is XmlException)
			{
				var completePath = ((XmlException)exception).SourceUri;
				var folder = Path.GetDirectoryName(completePath).Remove(0,6);
				var filename = Path.GetFileName(completePath);
				message = "Missing tag in " + filename + " in folder\n" + folder;
			}
			return new Exception(message);
		}
	}
}
