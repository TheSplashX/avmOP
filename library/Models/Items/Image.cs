using avmOP.DLL.Constants.Types;
using avmOP.DLL.Utils;

namespace avmOP.DLL.Models.Items
{
	class Image	: Item
	{
		public EnumImageType ImageType;

		public Image(string p_File) : base(p_File)
		{
			ImageType = FileUtil.GetImageType(p_File);
		}
	}
}
