namespace win_form_heads_or_tails
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bienvenida = new System.Windows.Forms.Label();
            this.opción = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnapostar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bienvenida
            // 
            this.bienvenida.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(138, 23);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(526, 40);
            this.bienvenida.TabIndex = 1;
            this.bienvenida.Text = "Ahora a Apostar";
            this.bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opción
            // 
            this.opción.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opción.Location = new System.Drawing.Point(172, 96);
            this.opción.Name = "opción";
            this.opción.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.opción.Size = new System.Drawing.Size(453, 40);
            this.opción.TabIndex = 2;
            this.opción.Text = "?Cuánta cantidad quieres apostar¿";
            this.opción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(319, 153);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(160, 35);
            this.txtcantidad.TabIndex = 3;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // btnapostar
            // 
            this.btnapostar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapostar.Location = new System.Drawing.Point(334, 204);
            this.btnapostar.Name = "btnapostar";
            this.btnapostar.Size = new System.Drawing.Size(132, 42);
            this.btnapostar.TabIndex = 7;
            this.btnapostar.Text = "Apostar";
            this.btnapostar.UseVisualStyleBackColor = true;
            this.btnapostar.Click += new System.EventHandler(this.btnapostar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(12, 396);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(132, 42);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Form2
            // 
            this.AccessibleName = "ApuestaForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnapostar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.opción);
            this.Controls.Add(this.bienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apuestas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label opción;
        private System.Windows.Forms.Button btnapostar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtcantidad;
    }
}