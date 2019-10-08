using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ControlListBox : UserControl
    {
        void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] countries = { "производитель1", "производитель2", "производитель3", "производитель4", "производитель5" };
            listBox1.Items.AddRange(countries);

            listBox1.SelectedIndexChanged += listBox_SelectedIndexChanged;
            string selectedCountry = listBox1.SelectedItem.ToString();
            MessageBox.Show(selectedCountry);
        }
    }
}
