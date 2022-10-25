namespace win_form_heads_or_tails
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bienvenida = new System.Windows.Forms.Label();
            this.opción = new System.Windows.Forms.Label();
            this.btncara = new System.Windows.Forms.Button();
            this.btnsello = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coinimage = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinimage)).BeginInit();
            this.SuspendLayout();
            // 
            // bienvenida
            // 
            this.bienvenida.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(150, 23);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(526, 40);
            this.bienvenida.TabIndex = 0;
            this.bienvenida.Text = "Bienvenid@ al juego de Cara o Cruz";
            this.bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opción
            // 
            this.opción.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opción.Location = new System.Drawing.Point(243, 102);
            this.opción.Name = "opción";
            this.opción.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.opción.Size = new System.Drawing.Size(313, 40);
            this.opción.TabIndex = 1;
            this.opción.Text = "Por favor elige tú opción";
            this.opción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncara
            // 
            this.btncara.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncara.Location = new System.Drawing.Point(243, 182);
            this.btncara.Name = "btncara";
            this.btncara.Size = new System.Drawing.Size(106, 42);
            this.btncara.TabIndex = 2;
            this.btncara.Text = "Cara";
            this.btncara.UseVisualStyleBackColor = true;
            this.btncara.Click += new System.EventHandler(this.btncara_Click);
            // 
            // btnsello
            // 
            this.btnsello.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsello.Location = new System.Drawing.Point(444, 182);
            this.btnsello.Name = "btnsello";
            this.btnsello.Size = new System.Drawing.Size(106, 42);
            this.btnsello.TabIndex = 3;
            this.btnsello.Text = "Sello";
            this.btnsello.UseVisualStyleBackColor = true;
            this.btnsello.Click += new System.EventHandler(this.btnsello_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::win_form_heads_or_tails.Properties.Resources._1000Sello;
            this.pictureBox1.Location = new System.Drawing.Point(444, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // coinimage
            // 
            this.coinimage.Image = global::win_form_heads_or_tails.Properties.Resources._1000Cara;
            this.coinimage.Location = new System.Drawing.Point(243, 259);
            this.coinimage.Name = "coinimage";
            this.coinimage.Size = new System.Drawing.Size(106, 102);
            this.coinimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinimage.TabIndex = 4;
            this.coinimage.TabStop = false;
            this.coinimage.Click += new System.EventHandler(this.coinimage_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(328, 396);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(132, 42);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coinimage);
            this.Controls.Add(this.btnsello);
            this.Controls.Add(this.btncara);
            this.Controls.Add(this.opción);
            this.Controls.Add(this.bienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opción";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label opción;
        private System.Windows.Forms.Button btncara;
        private System.Windows.Forms.Button btnsello;
        private System.Windows.Forms.PictureBox coinimage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncancelar;
    }
}