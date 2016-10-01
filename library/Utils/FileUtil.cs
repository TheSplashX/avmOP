using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using avmOP.DLL.Configuration;
using avmOP.DLL.Constants.Types;
using avmOP.DLL.Models.Items;

namespace avmOP.DLL.Utils
{
	public class FileUtil
	{
		public static List<string> GetAllFilesFromDir(string p_Dir) {
			return Directory.GetFiles(p_Dir, "*", SearchOption.AllDirectories).Where(file => ((File.GetAttributes(file) & FileAttributes.Hidden) != FileAttributes.Hidden)).ToList();
		}

		public static EnumFileType GetFileType(string p_File)
		{
			var ext = Path.GetExtension(p_File).TrimStart('.');
			var extension = ListExtensions.GetExtensionList.Where(x => x.Ext == ext).FirstOrDefault();
			if (extension!=null)
			{
				return extension.Type;
			}
			return EnumFileType.UNDEFINED;
		}

		public static Extension GetExtensionFromFile(string p_File)
		{
			var ext = Path.GetExtension(p_File);
			return ListExtensions.GetExtensionList.Where(x => x.Ext == ext).FirstOrDefault();
		}

		public static EnumImageType GetImageType(string p_File)
		{	
			foreach(EnumImageType imageType in Enum.GetValues(typeof(EnumImageType)))
			{
				if (p_File.Contains(imageType.ToString()))
				{
					return imageType;
				}
			}
			return EnumImageType.UNDEFINED;
		}

		public static void MoveFile(Item p_File, string p_DirDest)
		{
			var origin = p_File.GetCompletePath();
			var destination = p_DirDest + @"\" + p_File.FileName;
			try
			{
				Directory.CreateDirectory(p_DirDest);
				if (!Directory.Exists(p_DirDest))
				{
					return;
				}
				if(!File.Exists(origin))
				{
					return;
				}
				if(File.Exists(destination))
				{
					return;
				}
				File.Move(p_File.GetCompletePath(), p_DirDest + @"\" + p_File.FileName);
				if(!File.Exists(destination))
				{
					return;
				}
			}
			catch
			{
				throw;
			}
		}
	}
}
																					   