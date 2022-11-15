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
            NamedPipeClientStream npcs = new NamedPipeClientStream(".","MicrofonoCliente", PipeDirection.In);
            npcs.Connect();
            StreamReader sr = new StreamReader(npcs);

            NamedPipeServerStream npss = new NamedPipeServerStream("MicrofonoCli", PipeDirection.Out);
            npss.WaitForConnection();
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush = true;

            String mensaje = sr.ReadLine();
            Console.WriteLine(mensaje);
            sw.WriteLine(mensaje);
            while (mensaje.CompareTo("EOF")!=0)
            {
                mensaje = sr.ReadLine();
                Console.WriteLine(mensaje);
                sw.WriteLine(mensaje);
            }
            npcs.Close();
            sw.Close();
            sr.Close();
        }
    }
}
