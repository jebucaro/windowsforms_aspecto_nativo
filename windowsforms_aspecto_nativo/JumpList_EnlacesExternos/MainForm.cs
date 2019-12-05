using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JumpList_EnlacesExternos
{
    public partial class MainForm : Form
    {
        JumpList jlist;
        public MainForm()
        {
            // use Segoe UI in Vista & 7
            Font = SystemFonts.MessageBoxFont;

            InitializeComponent();

            // Crea un nuevo JumpList para la aplicación
            jlist = JumpList.CreateJumpListForIndividualWindow(TaskbarManager.Instance.ApplicationId, this.Handle);
            ConstruirLista();
        }

        private void ConstruirLista()
        {
            // Define una nueva categoría personalizada llamada Utilidades
            JumpListCustomCategory catActions = new JumpListCustomCategory("Utilidades");

            // Genera el path completo hacia la aplicación e icono a utilizar por el JumpListItem
            string notepadPath = Path.Combine(Environment.SystemDirectory, "notepad.exe");
            JumpListLink jlNotepad = new JumpListLink(notepadPath, "Notepad");
            jlNotepad.IconReference = new IconReference(notepadPath, 0);

            string calcPath = Path.Combine(Environment.SystemDirectory, "calc.exe");
            JumpListLink jlCalculadora = new JumpListLink(calcPath, "Calculadora");
            jlCalculadora.IconReference = new IconReference(calcPath, 0);

            string paintPath = Path.Combine(Environment.SystemDirectory, "mspaint.exe");
            JumpListLink jlPaint = new JumpListLink(paintPath, "Paint");
            jlPaint.IconReference = new IconReference(paintPath, 0);

            // Añade los JumpListItems a la categoría personalizada
            catActions.AddJumpListItems(jlNotepad, jlCalculadora, jlPaint);

            // Añade la categoría a la lista
            jlist.AddCustomCategories(catActions);
            jlist.Refresh();
        }
    }
}
