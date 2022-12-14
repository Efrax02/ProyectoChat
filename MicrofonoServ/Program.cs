using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MicrofonoServ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mensaje;

            NamedPipeServerStream npssForm = new NamedPipeServerStream("MicrofonoServidor1", PipeDirection.In);
            npssForm.WaitForConnection();
            StreamReader srForm = new StreamReader(npssForm);

            //PipeSecurity ps = new PipeSecurity();
            //ps.AddAccessRule(new PipeAccessRule("Efrain", PipeAccessRights.ReadWrite, AccessControlType.Allow));
            NamedPipeServerStream npssAuricCS = new NamedPipeServerStream("MicrofonoServidor2", PipeDirection.Out/*, 1, PipeTransmissionMode.Byte, PipeOptions.None, 100, 100, ps*/);
            npssAuricCS.WaitForConnection();
            StreamWriter swAuric = new StreamWriter(npssAuricCS);
            swAuric.AutoFlush = true;

            mensaje = srForm.ReadLine();
            while (!mensaje.Equals("EOF"))
            {                
                swAuric.WriteLine(mensaje);
                mensaje = srForm.ReadLine();
            }
            srForm.Close();
            swAuric.Close();
            npssForm.Close();
            npssAuricCS.Close();
        }
    }
}
