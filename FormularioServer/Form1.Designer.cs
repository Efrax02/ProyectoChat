namespace FormularioServer
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
            this.btnConectarServ = new System.Windows.Forms.Button();
            this.btnEnviarServ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnviarServ = new System.Windows.Forms.TextBox();
            this.txtRecibidoServ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConectarServ
            // 
            this.btnConectarServ.Location = new System.Drawing.Point(174, 190);
            this.btnConectarServ.Name = "btnConectarServ";
            this.btnConectarServ.Size = new System.Drawing.Size(75, 23);
            this.btnConectarServ.TabIndex = 7;
            this.btnConectarServ.Text = "Conectar";
            this.btnConectarServ.UseVisualStyleBackColor = true;
            this.btnConectarServ.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviarServ
            // 
            this.btnEnviarServ.Location = new System.Drawing.Point(61, 190);
            this.btnEnviarServ.Name = "btnEnviarServ";
            this.btnEnviarServ.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarServ.TabIndex = 8;
            this.btnEnviarServ.Text = "Enviar";
            this.btnEnviarServ.UseVisualStyleBackColor = true;
            this.btnEnviarServ.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enviar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recibido";
            // 
            // txtEnviarServ
            // 
            this.txtEnviarServ.Location = new System.Drawing.Point(61, 143);
            this.txtEnviarServ.Name = "txtEnviarServ";
            this.txtEnviarServ.Size = new System.Drawing.Size(270, 20);
            this.txtEnviarServ.TabIndex = 3;
            // 
            // txtRecibidoServ
            // 
            this.txtRecibidoServ.Location = new System.Drawing.Point(61, 66);
            this.txtRecibidoServ.Name = "txtRecibidoServ";
            this.txtRecibidoServ.Size = new System.Drawing.Size(270, 20);
            this.txtRecibidoServ.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 241);
            this.Controls.Add(this.btnConectarServ);
            this.Controls.Add(this.btnEnviarServ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnviarServ);
            this.Controls.Add(this.txtRecibidoServ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectarServ;
        private System.Windows.Forms.Button btnEnviarServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnviarServ;
        private System.Windows.Forms.TextBox txtRecibidoServ;
    }
}

