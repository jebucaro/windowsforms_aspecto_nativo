using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_AspectoNativo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // use Segoe UI in Vista & 7
            Font = SystemFonts.MessageBoxFont;

            InitializeComponent();

            TreeNode tn;

            nativeTreeView1.BeginUpdate();
            tn = nativeTreeView1.Nodes.Add("9gag", "9gag", 0, 0);
            tn.Nodes.Add("500px", "500px", 1, 1);
            tn.Nodes.Add("Evernote", "Evernote", 2, 2);
            tn.Nodes.Add("Messenger", "Messenger", 3, 3);
            tn = nativeTreeView1.Nodes.Add("Facebook", "Facebook", 4, 4);
            tn.Nodes.Add("Firefox", "Firefox", 5, 5);
            tn = nativeTreeView1.Nodes.Add("Flipboard", "Flipboard", 6, 6);
            tn.Nodes.Add("Google", "Google", 7, 7);
            tn.Nodes.Add("Google Plus", "Google Plus", 8, 8);
            tn.Nodes.Add("Internet Explorer", "Internet Explorer", 9, 9);
            tn.Nodes.Add("Ingress", "Ingress", 10, 10);
            tn.Nodes.Add("Instagram", "Instagram", 11, 11);
            tn.Nodes.Add("Office", "Office", 12, 12);
            tn.Nodes.Add("Opera", "Opera", 13, 13);
            tn.Nodes.Add("Pinterest", "Pinterest", 14, 14);
            tn.Nodes.Add("Pocket", "Pocket", 15, 15);
            tn.Nodes.Add("OneDrive", "OneDrive", 16, 16);
            tn.Nodes.Add("Twitter", "Twitter", 17, 17);

            nativeTreeView1.EndUpdate();
        }
    }
}
