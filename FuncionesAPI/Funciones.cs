using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAPI
{
    public class Funciones
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr handle, int message, IntPtr wparam, IntPtr lparam);
    }
}
