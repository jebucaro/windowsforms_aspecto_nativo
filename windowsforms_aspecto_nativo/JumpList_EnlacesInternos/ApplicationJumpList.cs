using System;
using System.Reflection;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace JumpList_EnlacesInternos
{
    class ApplicationJumpList
    {
        private JumpList myJumpList;

        public ApplicationJumpList(IntPtr windowHandle)
        {
            // Crea un nuevo JumpList para la aplicación
            myJumpList = JumpList.CreateJumpListForIndividualWindow(TaskbarManager.Instance.ApplicationId, windowHandle);
            ConstruirLista();
        }

        private void ConstruirLista()
        {
            // Crea los link que ejecutarán la aplicación con los argumentos asignados
            JumpListLink accionUsarGoogle = new JumpListLink(Assembly.GetEntryAssembly().Location, "Google");
            accionUsarGoogle.Arguments = "/g";

            JumpListLink accionUsarBing = new JumpListLink(Assembly.GetEntryAssembly().Location, "Bing");
            accionUsarBing.Arguments = "/b";

            JumpListLink accionUsarDuckDuckGo = new JumpListLink(Assembly.GetEntryAssembly().Location, "DuckDuckGo");
            accionUsarDuckDuckGo.Arguments = "/d";

            JumpListLink accionUsarYahoo = new JumpListLink(Assembly.GetEntryAssembly().Location, "Yahoo");
            accionUsarYahoo.Arguments = "/y";

            // Añade los links al JumpList
            myJumpList.AddUserTasks(accionUsarGoogle, accionUsarBing, accionUsarDuckDuckGo, accionUsarYahoo);
            myJumpList.Refresh();
        }
    }
}
