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

namespace AuricularServ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mensaje;
            PipeSecurity ps = new PipeSecurity();
            ps.AddAccessRule(new PipeAccessRule("Efrain", PipeAccessRights.ReadWrite, AccessControlType.Allow));
            NamedPipeServerStream npssMicroServ = new NamedPipeServerStream("AuricularCliente", PipeDirection.In, 1, PipeTransmissionMode.Byte, PipeOptions.None, 100, 100, ps);
            npssMicroServ.WaitForConnection();
            StreamReader srMicro = new StreamReader(npssMicroServ);


            NamedPipeServerStream npssForm = new NamedPipeServerStream("AuricularServidor", PipeDirection.Out);
            npssForm.WaitForConnection();
            StreamWriter swForm = new StreamWriter(npssForm);
            swForm.AutoFlush = true;

            int WH_MENSAJE;
            WH_MENSAJE = Funciones.RegisterWindowMessage("WM_MENSAJEREC");
            IntPtr h = Process.GetProcessesByName("FormularioServer")[0].MainWindowHandle;

            mensaje = srMicro.ReadLine();
            while (!mensaje.Equals("EOF"))
            {
                //Console.WriteLine(mensaje);
                Funciones.PostMessage(h, WH_MENSAJE, IntPtr.Zero, IntPtr.Zero);
                swForm.WriteLine(mensaje);
                mensaje = Console.ReadLine();
                mensaje = srMicro.ReadLine();
            }
        }
    }
}
