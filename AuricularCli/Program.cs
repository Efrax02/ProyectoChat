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

            int WH_MENSAJE;
            WH_MENSAJE = Funciones.RegisterWindowMessage("WH_MENSAJE");
            IntPtr h = Process.GetProcessesByName("FormularioCliente")[0].MainWindowHandle;
            NamedPipeServerStream npss = new NamedPipeServerStream("AuricularCliente", PipeDirection.InOut);
            npss.WaitForConnection();
            StreamReader sr = new StreamReader(npss);
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush = true;
            String mensaje;
            mensaje = Console.ReadLine();
            Funciones.PostMessage(h, WH_MENSAJE, IntPtr.Zero, IntPtr.Zero);
            sw.WriteLine(mensaje);
            Console.Clear();
            while (mensaje.CompareTo("EOF") != 0)
            {
                Funciones.PostMessage(h, WH_MENSAJE, IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(mensaje);
                //mensaje = sr.ReadLine();
                mensaje = Console.ReadLine();
            }
            sw.Close();
            npss.WaitForPipeDrain();
            npss.Close();
        }
    }
}
