using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ComputerNetworks
{
    public partial class whitelist : Form
    {

        public static TreeView BlackListView = new TreeView();
        

        public whitelist()
        {
            InitializeComponent();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BlackListView = treeView1;
            WebMethods.XmlReader();
        }

        private void RemoveFromBlacklist(object sender, MouseEventArgs e)
        {
            TreeNode treeNode = BlackListView.SelectedNode;

            if (BlackListView.SelectedNode.Text != "parent")
            {
                WebMethods.XmlRemove(treeNode);
                BlackListView.Nodes.Remove(treeNode);
            }

            else
            {
                MessageBox.Show("You cannot remove a category! To edit categories, access the \"______\" menu");
            }
                        
        }
    }
}
