namespace FormularioCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEnviarCli = new System.Windows.Forms.TextBox();
            this.btnEnviarCli = new System.Windows.Forms.Button();
            this.btnConectarCli = new System.Windows.Forms.Button();
            this.lstMensajesCli = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnviarCli
            // 
            this.txtEnviarCli.Location = new System.Drawing.Point(12, 257);
            this.txtEnviarCli.Name = "txtEnviarCli";
            this.txtEnviarCli.Size = new System.Drawing.Size(511, 20);
            this.txtEnviarCli.TabIndex = 0;
            // 
            // btnEnviarCli
            // 
            this.btnEnviarCli.Location = new System.Drawing.Point(12, 283);
            this.btnEnviarCli.Name = "btnEnviarCli";
            this.btnEnviarCli.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarCli.TabIndex = 1;
            this.btnEnviarCli.Text = "Enviar";
            this.btnEnviarCli.UseVisualStyleBackColor = true;
            this.btnEnviarCli.Click += new System.EventHandler(this.btnEnviarServ_Click);
            // 
            // btnConectarCli
            // 
            this.btnConectarCli.Location = new System.Drawing.Point(360, 283);
            this.btnConectarCli.Name = "btnConectarCli";
            this.btnConectarCli.Size = new System.Drawing.Size(75, 23);
            this.btnConectarCli.TabIndex = 2;
            this.btnConectarCli.TabStop = false;
            this.btnConectarCli.Text = "Conectar";
            this.btnConectarCli.UseVisualStyleBackColor = true;
            this.btnConectarCli.Click += new System.EventHandler(this.btnConectarServ_Click);
            // 
            // lstMensajesCli
            // 
            this.lstMensajesCli.HideSelection = false;
            this.lstMensajesCli.Location = new System.Drawing.Point(12, 12);
            this.lstMensajesCli.Name = "lstMensajesCli";
            this.lstMensajesCli.Size = new System.Drawing.Size(511, 239);
            this.lstMensajesCli.TabIndex = 3;
            this.lstMensajesCli.TabStop = false;
            this.lstMensajesCli.UseCompatibleStateImageBehavior = false;
            this.lstMensajesCli.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ip";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(436, 283);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(87, 23);
            this.btnDesconectar.TabIndex = 6;
            this.btnDesconectar.TabStop = false;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 318);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstMensajesCli);
            this.Controls.Add(this.btnConectarCli);
            this.Controls.Add(this.btnEnviarCli);
            this.Controls.Add(this.txtEnviarCli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEnviarCli;
        private System.Windows.Forms.Button btnEnviarCli;
        private System.Windows.Forms.Button btnConectarCli;
        private System.Windows.Forms.ListView lstMensajesCli;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
    }
}

