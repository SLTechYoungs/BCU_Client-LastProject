using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

	public partial class Form1 : Form
	{
		private Form2 _form2 = new Form2();
		public Form1()
		{
			InitializeComponent();
		}

		private void bunifuPanel1_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			bunifuPages1.SetPage("회원가입");
		}

		private void bunifuButton22_Click_1(object sender, EventArgs e)
		{
			bunifuPages1.SetPage("로그인");
		}

		private void bunifuButton21_Click(object sender, EventArgs e)
		{
			_form2.Show();
			this.Hide();
		}

		private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bunifuFormCaptionButton2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}
	}
}
