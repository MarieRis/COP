using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControlLibrary
{
	public partial class ControlTextBox : UserControl
	{
        //public string Text
        //{
        //    get { textBox.Text; }
        //    set { textBox.Text = value; } 
        //}

		public ControlTextBox()
		{
			InitializeComponent();
		}

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            string countInSklad="";
            textBox.Text = countInSklad;
        }
    }
}
