using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using FuncionesAPI;
using System.Net.Http;
using System.Security.AccessControl;

namespace MicrofonoCli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "AuricularServ", PipeDirection.Out);
            npcs.Connect();
            StreamWriter sw = new StreamWriter(npcs);
            sw.AutoFlush = true;

            NamedPipeServerStream npss = new NamedPipeServerStream("MicrofonoCliente", PipeDirection.In);
            npss.WaitForConnection();
            StreamReader sr = new StreamReader(npss);
            

            String mensaje = sr.ReadLine();
            //Console.WriteLine(mensaje);
            sw.WriteLine(mensaje);
            while (mensaje.CompareTo("EOF")!=0)
            {
                mensaje = sr.ReadLine();
                //Console.WriteLine(mensaje);
                sw.WriteLine(mensaje);
            }
            npss.Close();
            npcs.Close();
            sw.Close();
            sr.Close();
            
        }
    }
}
