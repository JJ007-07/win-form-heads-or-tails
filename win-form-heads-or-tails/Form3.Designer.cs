namespace win_form_heads_or_tails
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.coinimage = new System.Windows.Forms.PictureBox();
            this.btnarrojarmoneda = new System.Windows.Forms.Button();
            this.bienvenida = new System.Windows.Forms.Label();
            this.opción = new System.Windows.Forms.Label();
            this.txtcantidadmostrar = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coinimage)).BeginInit();
            this.SuspendLayout();
            // 
            // coinimage
            // 
            this.coinimage.Image = global::win_form_heads_or_tails.Properties.Resources._1000Cara;
            this.coinimage.Location = new System.Drawing.Point(549, 72);
            this.coinimage.Name = "coinimage";
            this.coinimage.Size = new System.Drawing.Size(216, 208);
            this.coinimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinimage.TabIndex = 0;
            this.coinimage.TabStop = false;
            // 
            // btnarrojarmoneda
            // 
            this.btnarrojarmoneda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarrojarmoneda.Location = new System.Drawing.Point(549, 325);
            this.btnarrojarmoneda.Name = "btnarrojarmoneda";
            this.btnarrojarmoneda.Size = new System.Drawing.Size(216, 38);
            this.btnarrojarmoneda.TabIndex = 1;
            this.btnarrojarmoneda.Text = "Arrojar";
            this.btnarrojarmoneda.UseVisualStyleBackColor = true;
            this.btnarrojarmoneda.Click += new System.EventHandler(this.btnarrojarmoneda_Click);
            // 
            // bienvenida
            // 
            this.bienvenida.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(137, 18);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(526, 40);
            this.bienvenida.TabIndex = 2;
            this.bienvenida.Text = "Ahora arroja la moneda";
            this.bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opción
            // 
            this.opción.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opción.Location = new System.Drawing.Point(12, 134);
            this.opción.Name = "opción";
            this.opción.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.opción.Size = new System.Drawing.Size(245, 40);
            this.opción.TabIndex = 3;
            this.opción.Text = "Cantidad apostada";
            this.opción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcantidadmostrar
            // 
            this.txtcantidadmostrar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadmostrar.Location = new System.Drawing.Point(276, 134);
            this.txtcantidadmostrar.Name = "txtcantidadmostrar";
            this.txtcantidadmostrar.ReadOnly = true;
            this.txtcantidadmostrar.Size = new System.Drawing.Size(160, 35);
            this.txtcantidadmostrar.TabIndex = 4;
            this.txtcantidadmostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidadmostrar.TextChanged += new System.EventHandler(this.txtcantidadmostrar_TextChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(12, 396);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(132, 42);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtcantidadmostrar);
            this.Controls.Add(this.opción);
            this.Controls.Add(this.bienvenida);
            this.Controls.Add(this.btnarrojarmoneda);
            this.Controls.Add(this.coinimage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.coinimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coinimage;
        private System.Windows.Forms.Button btnarrojarmoneda;
        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label opción;
        public System.Windows.Forms.TextBox txtcantidadmostrar;
        private System.Windows.Forms.Button btncancelar;
    }
}

