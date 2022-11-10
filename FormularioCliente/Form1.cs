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
using System.IO;
using System.IO.Pipes;

namespace FormularioCliente
{
    public partial class Form1 : Form
    {
        int WM_MENSAJEREC,WM_MENSAJEENV;
        NamedPipeClientStream npcs;
        StreamReader sr;

        public Form1()
        {
            InitializeComponent();
            WM_MENSAJEREC = Funciones.RegisterWindowMessage("WM_MENSAJEREC");
            WM_MENSAJEENV = Funciones.RegisterWindowMessage("WM_MENSAJEENV");
            npcs = new NamedPipeClientStream(".", "AuricularCliente", PipeDirection.InOut);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "..\\..\\..\\AuricularCli\\Bin\\Debug\\AuricularCli.exe";
            p.Start();           
            npcs.Connect();
            sr = new StreamReader(npcs);
            //p = new Process();
            //p.StartInfo.FileName = "..\\..\\..\\MicrofonoCli\\bin\\debug\\MicrofonoCli.exe";
            //p.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRecibido.Enabled = false;
        }

        protected override void DefWndProc(ref Message m)
        {
            
            if (m.Msg == WM_MENSAJEREC)
            {
                txtRecibido.Clear();
                string mensaje = sr.ReadLine();
                txtRecibido.Text = mensaje;
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
    }
}
