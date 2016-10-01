using System.Collections.Generic;
using System.IO;

namespace avmOP.DLL.Models.Items
{
	public class Video : Item
	{
		public List<Item> Images;
		public string RealName;

		// Audio
		public int Channels;
		public string Language;
		public string AudioCodec;
		public string AudioBitrate;
		// Video
		public string VideoCodec;
		public string VideoBitrate;
		public int Width;
		public int Height;
		public int Duration;
		public FileInfo test;

		public Video() : base() { }

		public Video(string p_File) : base(p_File)
		{
			test.
		}
	}
}
