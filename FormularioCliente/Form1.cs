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
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Process pac = new Process();
            pac.StartInfo.FileName = "..\\..\\..\\AuricularCli\\Bin\\Debug\\AuricularCli.exe";
            pac.Start();
            
            npcs = new NamedPipeClientStream(".", "AuricularCliente", PipeDirection.InOut);
            npcs.Connect();
            sr = new StreamReader(npcs);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRecibido.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        protected override void DefWndProc(ref Message m)
        {
            
            if (m.Msg == WM_MENSAJEREC)
            {
                txtRecibido.Clear();
                String mensaje = sr.ReadLine();
                txtRecibido.Text = mensaje;
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
    }
}
