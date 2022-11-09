using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using FuncionesAPI;

namespace AuricularCli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream(".","MicrofonoServidor", PipeDirection.In);
            npcs.Connect();
            StreamReader sr = new StreamReader(npcs);
            
            String mensaje="Hola";
            //mensaje=sr.ReadLine();
            
            NamedPipeServerStream npss = new NamedPipeServerStream("AuricularCliente", PipeDirection.Out);
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush = true;
            IntPtr h = Process.GetProcessesByName("FormularioCliente")[0].MainWindowHandle;
            int WH_MENSAJE;
            WH_MENSAJE = Funciones.RegisterWindowMessage("WH_MENSAJE");

            while (mensaje.CompareTo("EOF") != 0)
            {
                Funciones.PostMessage(h, WH_MENSAJE, IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(mensaje);
                mensaje = sr.ReadLine();
            }
            sr.Close();
            sw.Close();
            npcs.WaitForPipeDrain();
            npss.WaitForPipeDrain();
            npcs.Close();
            npss.Close();
        }
    }
}
