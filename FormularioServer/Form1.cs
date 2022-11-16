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
using FuncionesAPI;

namespace FormularioServer
{
    public partial class Form1 : Form
    {
        int WM_MENSAJEREC;
        NamedPipeClientStream npssa;
        NamedPipeClientStream npssm;
        StreamReader sr;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
            WM_MENSAJEREC = Funciones.RegisterWindowMessage("WM_MENSAJEREC");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sw.WriteLine(txtEnviarServ.Text);
            lstMensajesServ.Items.Add("YO: " + txtEnviarServ.Text);
            txtEnviarServ.Text = "";
            txtEnviarServ.Focus();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Conectar")
            {
                lstMensajesServ.Enabled = true;
                txtEnviarServ.Enabled = true;
                btnEnviarServ.Enabled = true;


                Process pas = new Process();
                pas.StartInfo.FileName = "..\\..\\..\\AuricularServ\\Bin\\Debug\\AuricularServ.exe";
                pas.Start();
                Process pms = new Process();
                pms.StartInfo.FileName = "..\\..\\..\\MicrofonoServ\\Bin\\Debug\\MicrofonoServ.exe";
                pms.Start();

                npssm = new NamedPipeClientStream(".", "MicrofonoServidor1", PipeDirection.Out);
                npssm.Connect();
                sw = new StreamWriter(npssm);
                sw.AutoFlush = true;

                npssa = new NamedPipeClientStream(".", "AuricularServidor2", PipeDirection.In);
                npssa.Connect();
                sr = new StreamReader(npssa);
                txtEnviarServ.Focus();
            }
        }
        protected override void DefWndProc(ref Message m)
        {

            if (m.Msg == WM_MENSAJEREC)
            {
                lstMensajesServ.Items.Add("Efrain: " + sr.ReadLine());
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
    }
}
