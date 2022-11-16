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

            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "MicrofonoServidor2", PipeDirection.In);
            npcs.Connect();
            StreamReader sr = new StreamReader(npcs);

            NamedPipeServerStream npss = new NamedPipeServerStream("AuricularCliente", PipeDirection.Out);
            npss.WaitForConnection();            
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush = true;
            
            String mensaje;
            mensaje = sr.ReadLine();
                        
            while (mensaje.CompareTo("EOF") != 0)
            {
                Funciones.PostMessage(h, WH_MENSAJE, IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(mensaje);
                mensaje = sr.ReadLine();                
            }
            
            sw.Close();
            sr.Close();
            npss.WaitForPipeDrain();
            npcs.WaitForPipeDrain();
            npss.Close();
            npcs.Close();
        }
    }
}
