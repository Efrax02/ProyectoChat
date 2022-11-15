using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioServer
{
    public partial class Form1 : Form
    {
        int WM_MENSAJEREC, WM_MENSAJEENV;
        NamedPipeServerStream npssa;
        NamedPipeClientStream npssm;
        StreamReader sr;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtRecibidoServ.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sw.WriteLine(txtEnviarServ.Text.ToString());
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Process pas = new Process();
            pas.StartInfo.FileName = "..\\..\\..\\AuricularServ\\Bin\\Debug\\AuricularServ.exe";
            pas.Start();
            Process pms= new Process();
            pms.StartInfo.FileName = "..\\..\\..\\MicrofonoServ\\Bin\\Debug\\MicrofonoServ.exe";
            pms.Start();

            //npssa = new NamedPipeServerStream(".","AuricularServidor",PipeDirection.Out);
            //npssa.WaitForConnection();
            //sr = new StreamReader(npssa);

            //npssm = new NamedPipeServerStream(".", "MicrofonoServidor", PipeDirection.Out);
            //npssm.Connect();
            //sw = new StreamWriter(npssm);

        }
        protected override void DefWndProc(ref Message m)
        {

            if (m.Msg == WM_MENSAJEREC)
            {
                //txtRecibidoServ.Clear();
                String mensaje = sr.ReadLine();
                //txtRecibidoServ.Text = mensaje;
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
    }
}
