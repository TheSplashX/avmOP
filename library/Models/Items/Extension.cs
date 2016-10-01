using avmOP.DLL.Constants.Types;

namespace avmOP.DLL.Models.Items
{
	public class Extension
	{
		public string Ext;
		public string Description;
		public EnumFileType Type;

		public Extension() { }

		public Extension(string p_Ext, string p_Description, EnumFileType p_Type)
		{
			Ext = p_Ext;
			Description = p_Description;
			Type = p_Type;
		}
	}
}
