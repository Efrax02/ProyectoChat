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
            this.lstMensajesServ = new System.Windows.Forms.ListView();
            this.btnConectarServ = new System.Windows.Forms.Button();
            this.btnEnviarServ = new System.Windows.Forms.Button();
            this.txtEnviarServ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMensajesServ
            // 
            this.lstMensajesServ.HideSelection = false;
            this.lstMensajesServ.Location = new System.Drawing.Point(12, 9);
            this.lstMensajesServ.Name = "lstMensajesServ";
            this.lstMensajesServ.Size = new System.Drawing.Size(554, 237);
            this.lstMensajesServ.TabIndex = 13;
            this.lstMensajesServ.TabStop = false;
            this.lstMensajesServ.UseCompatibleStateImageBehavior = false;
            this.lstMensajesServ.View = System.Windows.Forms.View.List;
            // 
            // btnConectarServ
            // 
            this.btnConectarServ.Location = new System.Drawing.Point(491, 278);
            this.btnConectarServ.Name = "btnConectarServ";
            this.btnConectarServ.Size = new System.Drawing.Size(75, 23);
            this.btnConectarServ.TabIndex = 12;
            this.btnConectarServ.TabStop = false;
            this.btnConectarServ.Text = "Conectar";
            this.btnConectarServ.UseVisualStyleBackColor = true;
            // 
            // btnEnviarServ
            // 
            this.btnEnviarServ.Location = new System.Drawing.Point(12, 278);
            this.btnEnviarServ.Name = "btnEnviarServ";
            this.btnEnviarServ.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarServ.TabIndex = 11;
            this.btnEnviarServ.Text = "Enviar";
            this.btnEnviarServ.UseVisualStyleBackColor = true;
            // 
            // txtEnviarServ
            // 
            this.txtEnviarServ.Location = new System.Drawing.Point(12, 252);
            this.txtEnviarServ.Name = "txtEnviarServ";
            this.txtEnviarServ.Size = new System.Drawing.Size(554, 20);
            this.txtEnviarServ.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 311);
            this.Controls.Add(this.lstMensajesServ);
            this.Controls.Add(this.btnConectarServ);
            this.Controls.Add(this.btnEnviarServ);
            this.Controls.Add(this.txtEnviarServ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstMensajesServ;
        private System.Windows.Forms.Button btnConectarServ;
        private System.Windows.Forms.Button btnEnviarServ;
        private System.Windows.Forms.TextBox txtEnviarServ;
    }
}

