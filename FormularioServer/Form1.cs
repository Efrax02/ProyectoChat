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
        NamedPipeServerStream npss;
        StreamReader sr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRecibido.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Process pac = new Process();
            pac.StartInfo.FileName = "..\\..\\..\\AuricularServ\\Bin\\Debug\\AuricularServ.exe";
            pac.Start();
            pac = new Process();
            pac.StartInfo.FileName = "..\\..\\..\\AuricularCli\\Bin\\Debug\\AuricularCli.exe";

            npss = new NamedPipeServerStream();
            npss.WaitForConnection();
            sr = new StreamReader(npss);

        }
    }
}
