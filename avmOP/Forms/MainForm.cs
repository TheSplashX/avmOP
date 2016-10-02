using System.Collections.Generic;
using System.Windows.Forms;
using avmOP.DLL.Utils;
using avmOP.DLL.Models.Items;
using System.Xml;
using System;
using MovieScrapper.DLL.Utils;
using avmOP.Forms;

namespace MovieScraper
{
	public partial class MainForm : Form
	{

		private Video SelectedMovie;
		 
		public MainForm()
		{
			this.InitializeComponent();
			//this.initMovieList();
			this.initForm();
		}

		private void initForm()
		{		
			try
			{
				XMLReader.ReadXML("config.xml");
			}
			catch(Exception ex)
			{
				new ExceptionForm(ex.Message);
			}
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
				var item = ItemFactory.GetItem(file);
				itemList.Add(item);
				if(item is Video)
				{
					this.pnlMovieList.Controls.Add(new MovieListUC((Video)item));
					FileUtil.MoveFile(item, @"d:\Share\Videos");
				}
				//ExceptionFactory.GetException(ex);
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
