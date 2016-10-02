using avmOP.DLL.Constants.Types;
using avmOP.DLL.Utils;

namespace avmOP.DLL.Models.Items
{
	public static class ItemFactory
	{
		public static Item GetItem(string p_File)
		{
			var type = FileUtil.GetFileType(p_File);
			switch(type)
			{
				case EnumFileType.Audio:
					return new Audio(p_File);
				case EnumFileType.Image:
					return new Image(p_File);
				case EnumFileType.Video:
					return new Video(p_File);
				case EnumFileType.NFO:
					return new NFO(p_File);

				default:
					return new Item(p_File);
			}
		}
	}
}
