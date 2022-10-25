namespace win_form_heads_or_tails
{
    partial class Form4
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.btnrepetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(12, 396);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(160, 42);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(12, 47);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(323, 40);
            this.txtresultado.TabIndex = 15;
            this.txtresultado.Text = "Saldo total disponible";
            this.txtresultado.Click += new System.EventHandler(this.txtresultado_Click);
            // 
            // txtfinal
            // 
            this.txtfinal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinal.Location = new System.Drawing.Point(523, 47);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.ReadOnly = true;
            this.txtfinal.Size = new System.Drawing.Size(160, 35);
            this.txtfinal.TabIndex = 18;
            this.txtfinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnrepetir
            // 
            this.btnrepetir.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepetir.Location = new System.Drawing.Point(628, 396);
            this.btnrepetir.Name = "btnrepetir";
            this.btnrepetir.Size = new System.Drawing.Size(160, 42);
            this.btnrepetir.TabIndex = 19;
            this.btnrepetir.Text = "Repetir Juego";
            this.btnrepetir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Image = global::win_form_heads_or_tails.Properties.Resources.Dokka;
            this.label1.Location = new System.Drawing.Point(306, 150);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.MinimumSize = new System.Drawing.Size(180, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 180);
            this.label1.TabIndex = 20;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrepetir);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btncancelar);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label txtresultado;
        public System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Button btnrepetir;
        private System.Windows.Forms.Label label1;
    }
}