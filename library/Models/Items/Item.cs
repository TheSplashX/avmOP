using System.IO;
using avmOP.DLL.Utils;

namespace avmOP.DLL.Models.Items
{
	public class Item
	{
		public string PathToFile;
		public string FileName;
		public Extension Ext;
		public int FileSize;

		public Item() { }

		public Item(string p_File)
		{
			PathToFile = Path.GetDirectoryName(p_File);
			FileName = Path.GetFileName(p_File);
			Ext = FileUtil.GetExtensionFromFile(p_File);
		}

		public string GetCompletePath()
		{
			return this.PathToFile + @"\" + this.FileName;
		}
	}
}
