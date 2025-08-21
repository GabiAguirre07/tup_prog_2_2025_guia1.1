namespace Ej1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabricacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTasaDepreciacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.nupModelo = new System.Windows.Forms.NumericUpDown();
            this.nupAñoACalcular = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoACalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a Calcular";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(48, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor de Fabricación $";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(126, 42);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(161, 32);
            this.tbMarca.TabIndex = 3;
            // 
            // tbValorFabricacion
            // 
            this.tbValorFabricacion.Location = new System.Drawing.Point(284, 183);
            this.tbValorFabricacion.Name = "tbValorFabricacion";
            this.tbValorFabricacion.Size = new System.Drawing.Size(178, 32);
            this.tbValorFabricacion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tasa de depreciación";
            // 
            // tbTasaDepreciacion
            // 
            this.tbTasaDepreciacion.Location = new System.Drawing.Point(799, 42);
            this.tbTasaDepreciacion.Name = "tbTasaDepreciacion";
            this.tbTasaDepreciacion.Size = new System.Drawing.Size(100, 32);
            this.tbTasaDepreciacion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vida Útil(años):";
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(799, 110);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 32);
            this.tbVidaUtil.TabIndex = 11;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(66, 314);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(197, 82);
            this.btnCalcularCosto.TabIndex = 12;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(315, 314);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(206, 82);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // nupModelo
            // 
            this.nupModelo.Location = new System.Drawing.Point(208, 92);
            this.nupModelo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupModelo.Name = "nupModelo";
            this.nupModelo.Size = new System.Drawing.Size(120, 32);
            this.nupModelo.TabIndex = 14;
            // 
            // nupAñoACalcular
            // 
            this.nupAñoACalcular.Location = new System.Drawing.Point(208, 137);
            this.nupAñoACalcular.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupAñoACalcular.Name = "nupAñoACalcular";
            this.nupAñoACalcular.Size = new System.Drawing.Size(120, 32);
            this.nupAñoACalcular.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.nupAñoACalcular);
            this.Controls.Add(this.nupModelo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTasaDepreciacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbValorFabricacion);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Tasación de Motos";
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoACalcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbValorFabricacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTasaDepreciacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown nupModelo;
        private System.Windows.Forms.NumericUpDown nupAñoACalcular;
    }
}

