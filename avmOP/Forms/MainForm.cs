using System.Collections.Generic;
using System.Windows.Forms;
using avmOP.DLL.Utils;
using avmOP.DLL.Models.Items;

namespace MovieScraper
{
	public partial class MainForm : Form
	{

		private Video SelectedMovie;
		 
		public MainForm()
		{
			this.InitializeComponent();
			this.initMovieList();
			this.initForm();
		}

		private void initForm()
		{

		}

		internal void SetSelectedMovie(Video p_Video)
		{
			this.SelectedMovie = p_Video;
		}

		private void initMovieList()
		{
			var fileList = FileUtil.GetAllFilesFromDir(@"d:\Share\Movies");
			var itemList = new List<Item>();
			foreach(string file in fileList)
			{
				var item = FactoryItem.Get(file);
				itemList.Add(item);
				if(item is Video)
				{
					this.pnlMovieList.Controls.Add(new MovieListUC((Video)item));
					FileUtil.MoveFile(item, @"d:\Share\Videos");
				}
			}
		}

		private void pnlMovieList_ControlAdded(object sender, ControlEventArgs e)
		{

		}

		private void pnlMovieList_ControlRemoved(object sender, ControlEventArgs e)
		{

		}
	}
}
