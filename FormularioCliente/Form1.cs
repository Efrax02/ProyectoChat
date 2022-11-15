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
        NamedPipeClientStream npcsa;
        NamedPipeClientStream npcsm;
        StreamReader sr;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
            WM_MENSAJEREC = Funciones.RegisterWindowMessage("WM_MENSAJEREC");
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Process pac = new Process();
            pac.StartInfo.FileName = "..\\..\\..\\AuricularCli\\Bin\\Debug\\AuricularCli.exe";
            pac.Start();

            Process pmc = new Process();
            pmc.StartInfo.FileName = "..\\..\\..\\MicrofonoCli\\Bin\\Debug\\MicrofonoCli.exe";
            pmc.Start();

            npcsa = new NamedPipeClientStream(".", "AuricularCliente", PipeDirection.InOut);
            npcsa.Connect();
            sr = new StreamReader(npcsa);

            npcsm = new NamedPipeClientStream(".", "MicrofonoCliente", PipeDirection.InOut);
            npcsm.Connect();
            sw = new StreamWriter(npcsm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRecibido.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sw.WriteLine(txtEnviar.Text.ToString());
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
