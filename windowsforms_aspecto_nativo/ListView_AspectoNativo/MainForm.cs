using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_AspectoNativo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // use Segoe UI in Vista & 7
            Font = SystemFonts.MessageBoxFont;

            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(View));

            nativeListView1.BeginUpdate();

            nativeListView1.Columns.Add("Nombre");
            nativeListView1.Columns.Add("Sitio");

            nativeListView1.Items.Add("9gag", 0).SubItems.Add("9gag.com");
            nativeListView1.Items.Add("500px", 1).SubItems.Add("500px.com");
            nativeListView1.Items.Add("Evernote", 2).SubItems.Add("evernote.com");
            nativeListView1.Items.Add("Facebook Messenger", 3).SubItems.Add("messenger.com/platform");
            nativeListView1.Items.Add("Facebook", 4).SubItems.Add("facebook.com");
            nativeListView1.Items.Add("Firefox", 5).SubItems.Add("mozilla.org/en-US/firefox/new");
            nativeListView1.Items.Add("Flipboard", 6).SubItems.Add("flipboard.com");
            nativeListView1.Items.Add("Google", 7).SubItems.Add("google.com");
            nativeListView1.Items.Add("Google Plus", 8).SubItems.Add("plus.google.com");
            nativeListView1.Items.Add("Internet Explorer", 9).SubItems.Add("windows.microsoft.com/en-us/internet-explorer/");
            nativeListView1.Items.Add("Ingress", 10).SubItems.Add("ingress.com");
            nativeListView1.Items.Add("instagram", 11).SubItems.Add("instagram.com");
            nativeListView1.Items.Add("Office", 12).SubItems.Add("office.microsoft.com");
            nativeListView1.Items.Add("Opera", 13).SubItems.Add("opera.com");
            nativeListView1.Items.Add("Pinterest", 14).SubItems.Add("pinterest.com");
            nativeListView1.Items.Add("Pocket", 15).SubItems.Add("getpocket.com");
            nativeListView1.Items.Add("OneDrive", 16).SubItems.Add("onedrive.live.com");
            nativeListView1.Items.Add("Twitter", 17).SubItems.Add("twitter.com");

            
            nativeListView1.EndUpdate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nativeListView1.View = (View)comboBox1.SelectedValue;
            nativeListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
