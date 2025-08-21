namespace Ej2
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
            this.btnViaje = new System.Windows.Forms.Button();
            this.btnParada = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizarViaje = new System.Windows.Forms.Button();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViaje
            // 
            this.btnViaje.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViaje.Location = new System.Drawing.Point(65, 39);
            this.btnViaje.Name = "btnViaje";
            this.btnViaje.Size = new System.Drawing.Size(619, 38);
            this.btnViaje.TabIndex = 0;
            this.btnViaje.Text = "Iniciar Viaje";
            this.btnViaje.UseVisualStyleBackColor = true;
            this.btnViaje.Click += new System.EventHandler(this.btnViaje_Click);
            // 
            // btnParada
            // 
            this.btnParada.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParada.Location = new System.Drawing.Point(65, 106);
            this.btnParada.Name = "btnParada";
            this.btnParada.Size = new System.Drawing.Size(619, 37);
            this.btnParada.TabIndex = 1;
            this.btnParada.Text = "Ingresar Parada";
            this.btnParada.UseVisualStyleBackColor = true;
            this.btnParada.Click += new System.EventHandler(this.btnParada_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinalizarViaje);
            this.groupBox1.Controls.Add(this.tbM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finalizar Parada";
            // 
            // btnFinalizarViaje
            // 
            this.btnFinalizarViaje.Location = new System.Drawing.Point(335, 132);
            this.btnFinalizarViaje.Name = "btnFinalizarViaje";
            this.btnFinalizarViaje.Size = new System.Drawing.Size(245, 52);
            this.btnFinalizarViaje.TabIndex = 4;
            this.btnFinalizarViaje.Text = "Finalizar Viaje";
            this.btnFinalizarViaje.UseVisualStyleBackColor = true;
            this.btnFinalizarViaje.Click += new System.EventHandler(this.btnFinalizarViaje_Click);
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(480, 64);
            this.tbM.Multiline = true;
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(86, 37);
            this.tbM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(358, 64);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(77, 32);
            this.tbH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Finalización [HH:MM]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnParada);
            this.Controls.Add(this.btnViaje);
            this.Name = "Form1";
            this.Text = "Empresa de Viajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViaje;
        private System.Windows.Forms.Button btnParada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinalizarViaje;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label label1;
    }
}

