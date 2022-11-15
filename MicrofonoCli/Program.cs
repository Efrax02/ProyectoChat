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

namespace MicrofonoCli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WM_MENSAJEENV;
            WM_MENSAJEENV = Funciones.RegisterWindowMessage("WM_MENSAJEENV");

            NamedPipeServerStream npss = new NamedPipeServerStream("MicrofonoCliente",PipeDirection.InOut);
            npss.WaitForConnection();
            StreamReader sr = new StreamReader(npss);
            StreamWriter sw = new StreamWriter(npss);
            sw.AutoFlush= true;

            String mensaje = sr.ReadLine();
            Console.WriteLine(mensaje);
            //sw.WriteLine(mensaje);
            while(mensaje !=null)
            {
                mensaje = sr.ReadLine();
                Console.WriteLine(mensaje);
                //sw.WriteLine(mensaje);
            }
        }
        //protected override void DefWndProc(ref MessageProcessingHandler m)
        //{

        //}
    }
}
