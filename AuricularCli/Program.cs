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
            NamedPipeServerStream npss = new NamedPipeServerStream("AuricularCliente", PipeDirection.InOut);
            npss.WaitForConnection();
            StreamReader sr = new StreamReader(npss);
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush=true;
            IntPtr h = Process.GetProcessesByName("FormularioCliente")[0].MainWindowHandle;
            int WH_MENSAJE;
            WH_MENSAJE = Funciones.RegisterWindowMessage("WH_MENSAJE");
            String mensaje;
            mensaje=sr.ReadLine();
            while(mensaje.CompareTo("EOF")!=0)
            {
                sw.WriteLine(mensaje);
                mensaje=sr.ReadLine();
            }
        }
    }
}
