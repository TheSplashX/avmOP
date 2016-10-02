using System.Net.Http;
using Newtonsoft.Json;

namespace avmOP.DLL.Utils
{
	public static class JsonUtil
	{
		public static dynamic TestJson()
		{
			var client = new HttpClient();
			var response = client.GetAsync("https://api.themoviedb.org/3/movie/76341?api_key=bc7bf315511c72e32a37076e41a08f45").Result;
			var test = response.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject(test);
		}
	}
}
