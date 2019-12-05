using System;
using System.Windows.Forms;

namespace JumpList_EnlacesInternos
{
    public partial class MainForm : Form
    {
        private ApplicationJumpList lista;
        public string PaginaInicio;

        public MainForm()
        {
            InitializeComponent();

            // Construir la lista
            lista = new ApplicationJumpList(this.Handle);

        }

        protected override void WndProc(ref Message m)
        {
            // En esta parte se interceptan los mensajes enviados a la aplicación.
            if (m.Msg == WindowsMessageHelper.UsarDuckDuckGo)
                webBrowser1.Navigate("www.duckduckgo.com");
            else if (m.Msg == WindowsMessageHelper.UsarGoogle)
                webBrowser1.Navigate("www.google.com");
            else if (m.Msg == WindowsMessageHelper.UsarBing)
                webBrowser1.Navigate("www.bing.com");
            else if (m.Msg == WindowsMessageHelper.UsarYahoo)
                webBrowser1.Navigate("www.yahoo.com");
            else
                base.WndProc(ref m);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Evalúa el parámetro recibido en caso sea la primera instancia
            switch (PaginaInicio)
            {
                case "/g":
                    webBrowser1.Navigate("www.google.com");
                    break;
                case "/b":
                    webBrowser1.Navigate("www.bing.com");
                    break;
                case "/d":
                    webBrowser1.Navigate("www.duckduckgo.com");
                    break;
                case "/y":
                    webBrowser1.Navigate("www.yahoo.com");
                    break;
            }
        }
    }
}
