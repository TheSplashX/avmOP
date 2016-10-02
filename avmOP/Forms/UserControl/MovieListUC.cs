using System.Windows.Forms;
using avmOP.DLL.Models.Items;

namespace avmOP
{
	public partial class MovieListUC : UserControl
	{
		public Video Movie;

		public MovieListUC(Video p_Movie)
		{
			this.Movie = p_Movie;
			InitializeComponent();

			this.init();
		}

		private void init()
		{
			this.lblMovieName.Text = Movie.FileName;
			this.Click += new System.EventHandler(this.MovieListUC_Click);
			foreach(Control control in Controls)
			{
				control.Click += new System.EventHandler(this.MovieListUC_Click);
			}
		}

		private void MovieListUC_Click(object sender, System.EventArgs e)
		{			
			((MainForm)this.ParentForm).SetSelectedMovie(Movie);
		}
	}
}
