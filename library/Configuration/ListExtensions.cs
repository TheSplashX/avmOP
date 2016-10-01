using avmOP.DLL.Constants.Types;
using avmOP.DLL.Models.Items;
using System.Collections.Generic;

namespace avmOP.DLL.Configuration
{
    public class ListExtensions
    {
		public static List<Extension> GetExtensionList = new List<Extension>() {
			// IMAGE
			new Extension("jpg","JPG",EnumFileType.Image),
			new Extension("png","PNG",EnumFileType.Image),
			new Extension("tbn","tbn",EnumFileType.Image),
			// AUDIO
			new Extension("3ga","3GPP multimedia file format",EnumFileType.Audio),
			new Extension("aac","Advanced audio coding file format",EnumFileType.Audio),
			new Extension("aiff","Audio Interchange Format",EnumFileType.Audio),
			new Extension("amr"," Adaptive Multi-Rate compressed audio format",EnumFileType.Audio),
			new Extension("ape","Monkey's Audio lossless audio compression format",EnumFileType.Audio),
			new Extension("arf","WebEx advanced recording files",EnumFileType.Audio),
			new Extension("asf","Advanced Systems (streaming) format",EnumFileType.Audio),
			new Extension("asx","Advanced Stream Redirectors",EnumFileType.Audio),
			new Extension("cda","audio CD",EnumFileType.Audio),
			new Extension("dvf","Digital Voice Editor software",EnumFileType.Audio),
			new Extension("flac"," Free Lossless Audio Codec",EnumFileType.Audio),
			new Extension("gp4","Guitar Pro 4",EnumFileType.Audio),
			new Extension("gp5","Guitar Pro 5",EnumFileType.Audio),
			new Extension("gpx","Guitar Pro version 6",EnumFileType.Audio),
			new Extension("logic","Apple Logic Pro",EnumFileType.Audio),
			new Extension("m4a","Apple Lossless (ALAC)",EnumFileType.Audio),
			new Extension("m4b","Apple MPEG-4 AAC audio files",EnumFileType.Audio),
			new Extension("m4p","AAC (advanced audio coding) ",EnumFileType.Audio),
			new Extension("midi","MIDI format",EnumFileType.Audio),
			new Extension("mp3","compressed audio file",EnumFileType.Audio),
			new Extension("ogg","Ogg Vorbis compressed audio format",EnumFileType.Audio),
			new Extension("pcm","uncompressed digital audio file",EnumFileType.Audio),
			new Extension("snd","audio file",EnumFileType.Audio),
			new Extension("sng","audio file",EnumFileType.Audio),
			new Extension("uax","Unreal game engine",EnumFileType.Audio),
			new Extension("wav","Wave Form Audio",EnumFileType.Audio),
			new Extension("wma","Windows Media Audio",EnumFileType.Audio),
			new Extension("wpl","Windows Media Player playlist",EnumFileType.Audio),
			new Extension("zab","Zipped Audio Book",EnumFileType.Audio),
			// VIDEO
			new Extension("264","H.264/MPEG-4 AVC",EnumFileType.Video),
			new Extension("3g2","3GPP2 multimedia file format",EnumFileType.Video),
			new Extension("3gp","3GPP networks",EnumFileType.Video),
			new Extension("avi","video format",EnumFileType.Video),
			new Extension("bik","Bink and Smacker game video codec",EnumFileType.Video),
			new Extension("dash","Dynamic Adaptive Streaming over HTTP video file format",EnumFileType.Video),
			new Extension("dat","MPEG-1 video",EnumFileType.Video),
			new Extension("dvr","MPEG-2 video",EnumFileType.Video),
			new Extension("flv","Flash video file",EnumFileType.Video),
			new Extension("h264","MPEG-4 H.264",EnumFileType.Video),
			new Extension("m2t","MPEG-2 transport video stream",EnumFileType.Video),
			new Extension("m2ts","BDAV MPEG-2",EnumFileType.Video),
			new Extension("m4v","MPEG-4 stream",EnumFileType.Video),
			new Extension("mkv","Matroska Multimedia Container",EnumFileType.Video),
			new Extension("mod","MPEG-2 stream file",EnumFileType.Video),
			new Extension("mov","QuickTime ",EnumFileType.Video),
			new Extension("mp4","MPEG-4 multimedia ISO 14496-1 standard",EnumFileType.Video),
			new Extension("mpeg","MPEG-1 video file",EnumFileType.Video),
			new Extension("mpg","MPEG-1 video file",EnumFileType.Video),
			new Extension("mswmm","Microsoft Windows Movie Maker",EnumFileType.Video),
			new Extension("mts","Advanced Video Coding High Definition format",EnumFileType.Video),
			new Extension("ogv","Ogg Vorbis video codec",EnumFileType.Video),
			new Extension("prproj","Adobe Premiere Pro",EnumFileType.Video),
			new Extension("rmvb","Realmedia ",EnumFileType.Video),
			new Extension("swf","Shockwave Flash movie",EnumFileType.Video),
			new Extension("tod","JVC MPEG-2 video",EnumFileType.Video),
			new Extension("tp","MPEG-2 video file",EnumFileType.Video),
			new Extension("ts","MPEG-TV video stream",EnumFileType.Video),
			new Extension("vob","Video Object",EnumFileType.Video),
			new Extension("webm","Matroska WebM video file",EnumFileType.Video),
			new Extension("wmv","Windows Media Video",EnumFileType.Video),
			//NFO
			new Extension("nfo","XML info file",EnumFileType.NFO),
			new Extension("info","not-XML info file",EnumFileType.NFO),
		};
	}
}
