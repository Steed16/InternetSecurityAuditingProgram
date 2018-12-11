﻿using System;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class whitelist : Form
    {

        public static TreeView BlackListView = new TreeView();
        public string RandomFactGenerator = "";

        public whitelist()
        {
            InitializeComponent();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RandomFactNum = rnd.Next(1, 1000);
            BlackListView = treeView1;
            RandomFactText.Text = RandomFactGenerator;
            WebMethods.XmlReader();
        }

        private void RemoveFromBlacklist(object sender, MouseEventArgs e)
        {
            TreeNode treeNode = BlackListView.SelectedNode;

            if (BlackListView.SelectedNode.Tag == null)
            {
                WebMethods.XmlRemove(treeNode).ContinueWith(res =>
                 {
                     if (res.Result) BlackListView.Nodes.Remove(treeNode);
                 });
            }
            else
            {
                MessageBox.Show("You cannot remove a category! To edit categories, access the \"______\" menu");
            }
                        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
