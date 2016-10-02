using System.Windows.Forms;

namespace avmOP.Forms
{
	public partial class ExceptionForm : Form
	{
		public ExceptionForm(string p_Message)
		{
			InitializeComponent();
			this.lblMessage.Text = p_Message;
			this.Width = this.lblMessage.Width + this.lblMessage.Location.X*2;
			this.Show();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
