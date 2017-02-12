using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbbox_searchType.SelectedIndex = 0;
		}

		private void cmbbox_searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbox_searchType.SelectedIndex == 0)
            {

            }
            else
            {
				
            }
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
