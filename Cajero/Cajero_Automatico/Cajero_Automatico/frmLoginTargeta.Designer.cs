namespace Cajero_Automatico
{
    partial class frmLoginTargeta
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
            this.LblNumeroTrj = new System.Windows.Forms.Label();
            this.LblPinTrj = new System.Windows.Forms.Label();
            this.TxtNumeroTrj = new System.Windows.Forms.TextBox();
            this.TxtPinTrj = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNumeroTrj
            // 
            this.LblNumeroTrj.AutoSize = true;
            this.LblNumeroTrj.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroTrj.Location = new System.Drawing.Point(223, 47);
            this.LblNumeroTrj.Name = "LblNumeroTrj";
            this.LblNumeroTrj.Size = new System.Drawing.Size(196, 16);
            this.LblNumeroTrj.TabIndex = 2;
            this.LblNumeroTrj.Text = "Ingrese numero de tarjeta";
            // 
            // LblPinTrj
            // 
            this.LblPinTrj.AutoSize = true;
            this.LblPinTrj.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPinTrj.Location = new System.Drawing.Point(237, 110);
            this.LblPinTrj.Name = "LblPinTrj";
            this.LblPinTrj.Size = new System.Drawing.Size(161, 16);
            this.LblPinTrj.TabIndex = 3;
            this.LblPinTrj.Text = "Ingrese pin de tarjeta";
            // 
            // TxtNumeroTrj
            // 
            this.TxtNumeroTrj.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroTrj.Location = new System.Drawing.Point(238, 72);
            this.TxtNumeroTrj.Name = "TxtNumeroTrj";
            this.TxtNumeroTrj.Size = new System.Drawing.Size(158, 25);
            this.TxtNumeroTrj.TabIndex = 4;
            // 
            // TxtPinTrj
            // 
            this.TxtPinTrj.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPinTrj.Location = new System.Drawing.Point(238, 138);
            this.TxtPinTrj.Name = "TxtPinTrj";
            this.TxtPinTrj.Size = new System.Drawing.Size(158, 25);
            this.TxtPinTrj.TabIndex = 5;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(271, 171);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(83, 23);
            this.BtnIngresar.TabIndex = 6;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(268, 207);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 23);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cajero_Automatico.Properties.Resources.tarjetas;
            this.pictureBox2.Location = new System.Drawing.Point(4, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cajero_Automatico.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLoginTargeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 344);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtPinTrj);
            this.Controls.Add(this.TxtNumeroTrj);
            this.Controls.Add(this.LblPinTrj);
            this.Controls.Add(this.LblNumeroTrj);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLoginTargeta";
            this.Text = "Cajeros JEP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblNumeroTrj;
        private System.Windows.Forms.Label LblPinTrj;
        private System.Windows.Forms.TextBox TxtNumeroTrj;
        private System.Windows.Forms.TextBox TxtPinTrj;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

