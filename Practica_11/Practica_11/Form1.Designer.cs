namespace Practica_11
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCiudad = new System.Windows.Forms.TextBox();
            this.btnQuien = new System.Windows.Forms.Button();
            this.lbQuien = new System.Windows.Forms.Label();
            this.txtbFechaAgregada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDiferencia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAleatoria = new System.Windows.Forms.Label();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbCumpleaños = new System.Windows.Forms.TextBox();
            this.btnCumpleaños = new System.Windows.Forms.Button();
            this.lbCumpleaños = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad";
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(95, 70);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(127, 20);
            this.txtbEdad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Aleatoria";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(95, 32);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(127, 20);
            this.txtbNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ciudad";
            // 
            // txtbCiudad
            // 
            this.txtbCiudad.Location = new System.Drawing.Point(95, 105);
            this.txtbCiudad.Name = "txtbCiudad";
            this.txtbCiudad.Size = new System.Drawing.Size(127, 20);
            this.txtbCiudad.TabIndex = 1;
            // 
            // btnQuien
            // 
            this.btnQuien.Location = new System.Drawing.Point(398, 35);
            this.btnQuien.Name = "btnQuien";
            this.btnQuien.Size = new System.Drawing.Size(75, 29);
            this.btnQuien.TabIndex = 2;
            this.btnQuien.Text = "¿Quién soy?";
            this.btnQuien.UseVisualStyleBackColor = true;
            this.btnQuien.Click += new System.EventHandler(this.btnQuien_Click);
            // 
            // lbQuien
            // 
            this.lbQuien.AutoSize = true;
            this.lbQuien.Location = new System.Drawing.Point(262, 77);
            this.lbQuien.MaximumSize = new System.Drawing.Size(500, 200);
            this.lbQuien.Name = "lbQuien";
            this.lbQuien.Size = new System.Drawing.Size(0, 13);
            this.lbQuien.TabIndex = 3;
            // 
            // txtbFechaAgregada
            // 
            this.txtbFechaAgregada.Location = new System.Drawing.Point(57, 211);
            this.txtbFechaAgregada.Name = "txtbFechaAgregada";
            this.txtbFechaAgregada.Size = new System.Drawing.Size(127, 20);
            this.txtbFechaAgregada.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingresa una Fecha";
            // 
            // lbDiferencia
            // 
            this.lbDiferencia.AutoSize = true;
            this.lbDiferencia.Location = new System.Drawing.Point(354, 211);
            this.lbDiferencia.Name = "lbDiferencia";
            this.lbDiferencia.Size = new System.Drawing.Size(0, 13);
            this.lbDiferencia.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Diferencia entre la fecha agregada y la fecha aleatoria";
            // 
            // lbAleatoria
            // 
            this.lbAleatoria.AutoSize = true;
            this.lbAleatoria.Location = new System.Drawing.Point(247, 211);
            this.lbAleatoria.Name = "lbAleatoria";
            this.lbAleatoria.Size = new System.Drawing.Size(81, 13);
            this.lbAleatoria.TabIndex = 0;
            this.lbAleatoria.Text = "Fecha Aleatoria";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(265, 243);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(75, 29);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 305);
            this.label6.MaximumSize = new System.Drawing.Size(100, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresa tu fecha de cumpleaños";
            // 
            // txtbCumpleaños
            // 
            this.txtbCumpleaños.Location = new System.Drawing.Point(174, 311);
            this.txtbCumpleaños.Name = "txtbCumpleaños";
            this.txtbCumpleaños.Size = new System.Drawing.Size(127, 20);
            this.txtbCumpleaños.TabIndex = 1;
            // 
            // btnCumpleaños
            // 
            this.btnCumpleaños.Location = new System.Drawing.Point(324, 306);
            this.btnCumpleaños.Name = "btnCumpleaños";
            this.btnCumpleaños.Size = new System.Drawing.Size(75, 29);
            this.btnCumpleaños.TabIndex = 2;
            this.btnCumpleaños.Text = "Cumpleaños";
            this.btnCumpleaños.UseVisualStyleBackColor = true;
            this.btnCumpleaños.Click += new System.EventHandler(this.btnCumpleaños_Click);
            // 
            // lbCumpleaños
            // 
            this.lbCumpleaños.AutoSize = true;
            this.lbCumpleaños.Location = new System.Drawing.Point(111, 351);
            this.lbCumpleaños.Name = "lbCumpleaños";
            this.lbCumpleaños.Size = new System.Drawing.Size(0, 13);
            this.lbCumpleaños.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 384);
            this.Controls.Add(this.lbQuien);
            this.Controls.Add(this.btnCumpleaños);
            this.Controls.Add(this.btnDiferencia);
            this.Controls.Add(this.btnQuien);
            this.Controls.Add(this.txtbCiudad);
            this.Controls.Add(this.txtbCumpleaños);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbFechaAgregada);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbAleatoria);
            this.Controls.Add(this.lbCumpleaños);
            this.Controls.Add(this.lbDiferencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbCiudad;
        private System.Windows.Forms.Button btnQuien;
        private System.Windows.Forms.Label lbQuien;
        private System.Windows.Forms.TextBox txtbFechaAgregada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDiferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAleatoria;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbCumpleaños;
        private System.Windows.Forms.Button btnCumpleaños;
        private System.Windows.Forms.Label lbCumpleaños;
    }
}

