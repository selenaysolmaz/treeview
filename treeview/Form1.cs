using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sürücülerin listesi alınıyor.
            string[] suruculer = Directory.GetLogicalDrives();
            //sürücüler listesinde dönülüyor.
            foreach(var surucu in suruculer)
            {
                //tüm sürücüleri okuyor.
                TreeNode SurucuNode = new TreeNode(surucu);
                //node ekliyor.
                treeView.Nodes.Add(SurucuNode);
                string[] altKlasorler;
                altKlasorler = Directory.GetDirectories(surucu);
                foreach(var altKlasor in altKlasorler)
                {
                    TreeNode altnode = new TreeNode(altKlasor);
                    SurucuNode.Nodes.Add(altnode);
                }
            }

        }
    }
}
