using System;
using System.Threading;
using System.Windows.Forms;

namespace JumpList_EnlacesInternos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool primeraInstancia = false;

            // Verifica si es la primera instancia de la aplicación, se usara un string que
            // representará el nombre de la aplicación, normalmente es usado un GUID
            Mutex mtx = new Mutex(true, "JumpListEnlacesInternos", out primeraInstancia);

            if (primeraInstancia)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm frmMain = new MainForm();

                // De existir parametros, se asignaran a la variable PaginaInicio del formulario
                if (Environment.GetCommandLineArgs().Length > 1)
                    frmMain.PaginaInicio = Environment.GetCommandLineArgs()[1];

                Application.Run(frmMain);
            }
            else
            {
                // De estar ejecutándose la aplicación, solamente se debe de procesar el mensaje
                if (Environment.GetCommandLineArgs().Length > 1)
                {
                    switch (Environment.GetCommandLineArgs()[1])
                    {
                        case "/g":
                            WindowsMessageHelper.SendMessage("JumpListEnlacesInternos", WindowsMessageHelper.UsarGoogle);
                            break;
                        case "/b":
                            WindowsMessageHelper.SendMessage("JumpListEnlacesInternos", WindowsMessageHelper.UsarBing);
                            break;
                        case "/d":
                            WindowsMessageHelper.SendMessage("JumpListEnlacesInternos", WindowsMessageHelper.UsarDuckDuckGo);
                            break;
                        case "/y":
                            WindowsMessageHelper.SendMessage("JumpListEnlacesInternos", WindowsMessageHelper.UsarYahoo);
                            break;
                    }
                }
            }
        }
    }
}
