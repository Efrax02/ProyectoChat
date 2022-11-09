using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesAPI;
using System.Diagnostics;

namespace FormularioCliente
{
    public partial class Form1 : Form
    {
        int WM_MENSAJEREC,WM_MENSAJEENV;

        private void Form1_Load(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "..\\..\\..\\AuricularCli\\bin\\debug\\AuricularCli.exe";
            p.Start();
            p = new Process();
            p.StartInfo.FileName = "..\\..\\..\\MicrofonoCli\\bin\\debug\\MicrofonoCli.exe";
            p.Start();
        }

        public Form1()
        {
            InitializeComponent();
            WM_MENSAJEREC = Funciones.RegisterWindowMessage("WM_MENSAJEREC");
            WM_MENSAJEENV = Funciones.RegisterWindowMessage("WM_MENSAJEENV");
        }
    }
}
