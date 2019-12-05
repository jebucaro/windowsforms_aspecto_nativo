using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TreeView_AspectoNativo
{
    class NativeTreeView : TreeView
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [DllImport("user32.dll")]
        public extern static int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void CreateHandle()
        {
            base.CreateHandle();
            // Aplicar el tema nativo del control TreeView
            SetWindowTheme(this.Handle, "explorer", null);
        }

        public NativeTreeView()
        {
            // Activar double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            // Habilitar el evento OnNotifyMessage para luego poder filtrar
            // el mensaje WM_ERASEBKGND antes de que sea procesado
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            // Filtrar el mensaje WM_ERASEBKGND
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }
    }
}
