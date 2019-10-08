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
	public partial class ControlTreeView : UserControl
	{
        Dictionary<string, TreeNode> categories;

		public ControlTreeView()
		{
			InitializeComponent();
            categories = new Dictionary<string, TreeNode>();
		}

        public void SetList<T>(List<T> productList, Func<T, object> getCategory)
        {
            foreach (T product in productList)
            {
                string cat = getCategory(product).ToString();

                if (!categories.Keys.Contains(cat))
                {
                    int index = treeView.Nodes.Add(new TreeNode(cat));
                    categories.Add(cat, treeView.Nodes[index]);
                }

                categories[cat].Nodes.Add(new TreeNode(product.ToString()));
            }

            treeView.ExpandAll();
        }
	}
}
