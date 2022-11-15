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
using System.Security.AccessControl;

namespace FormularioCliente
{
    public partial class Form1 : Form
    {
        int WM_MENSAJEREC;
        NamedPipeClientStream npcsa;
        NamedPipeServerStream npssm;
        StreamReader sr;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
            WM_MENSAJEREC = Funciones.RegisterWindowMessage("WM_MENSAJEREC");
            
        }

        private void btnConectarServ_Click(object sender, EventArgs e)
        {
            Process pac = new Process();
            pac.StartInfo.FileName = "..\\..\\..\\AuricularCli\\Bin\\Debug\\AuricularCli.exe";
            pac.Start();

            Process pmc = new Process();
            pmc.StartInfo.FileName = "..\\..\\..\\MicrofonoCli\\Bin\\Debug\\MicrofonoCli.exe";
            pmc.Start();
                     
            npcsa = new NamedPipeClientStream(".", "AuricularCliente", PipeDirection.In);
            npcsa.Connect();
            sr = new StreamReader(npcsa);

            npssm = new NamedPipeServerStream("MicrofonoCliente", PipeDirection.Out);
            npssm.WaitForConnection();
            sw = new StreamWriter(npssm);
            sw.AutoFlush = true;
        }

        private void btnEnviarServ_Click(object sender, EventArgs e)
        {
            sw.WriteLine(txtEnviarCli.Text);
            lstMensajesCli.Items.Add($"Cliente: {txtEnviarCli.Text}");
            txtEnviarCli.Clear();
        }
        protected override void DefWndProc(ref Message m)
        {
            
            if (m.Msg == WM_MENSAJEREC)
            {                
                String mensaje = sr.ReadLine();
                lstMensajesCli.Items.Add($"Servidor: {mensaje}");
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            sw.Close();
            sr.Close();
            npcsa.Close();
            npssm.Close();            
        }
    }
}
