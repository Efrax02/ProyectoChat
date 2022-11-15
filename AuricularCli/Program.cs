using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using FuncionesAPI;
using System.Security.AccessControl;

namespace AuricularCli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int WH_MENSAJE;
            WH_MENSAJE = Funciones.RegisterWindowMessage("WM_MENSAJEREC");
            IntPtr h = Process.GetProcessesByName("FormularioCliente")[0].MainWindowHandle;

            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "AuricularServ", PipeDirection.In);
            npcs.Connect();
            StreamReader sr = new StreamReader(npcs);

            NamedPipeServerStream npss = new NamedPipeServerStream("AuricularCliente", PipeDirection.Out);
            npss.WaitForConnection();            
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush = true;
            
            String mensaje;
            //mensaje = Console.ReadLine();
            mensaje = sr.ReadLine();
            Funciones.PostMessage(h, WH_MENSAJE, IntPtr.Zero, IntPtr.Zero);
            sw.WriteLine(mensaje);
            
            while (mensaje.CompareTo("EOF") != 0)
            {                
                //mensaje = Console.ReadLine(); 
                mensaje = sr.ReadLine();
                Funciones.PostMessage(h, WH_MENSAJE, IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(mensaje);
            }
            
            sw.Close();
            sr.Close();
            npss.WaitForPipeDrain();
            npss.Close();
        }
    }
}
