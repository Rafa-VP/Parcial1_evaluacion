namespace Parcial1_ejercicio02
{
    partial class frmEjercicio02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cadena de texto:";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(229, 51);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtString.Size = new System.Drawing.Size(298, 48);
            this.txtString.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(563, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 48);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstPalabras
            // 
            this.lstPalabras.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstPalabras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPalabras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(125, 129);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(340, 106);
            this.lstPalabras.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // btnSaludo
            // 
            this.btnSaludo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaludo.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaludo.Location = new System.Drawing.Point(563, 161);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(109, 41);
            this.btnSaludo.TabIndex = 5;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = false;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // frmEjercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label1);
            this.Name = "frmEjercicio02";
            this.Text = "Cuenta palabras y longitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaludo;
    }
}

