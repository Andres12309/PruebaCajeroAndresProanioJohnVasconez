namespace Cajero_Automatico
{
    partial class frmRetirar
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
            this.Rbtn10 = new System.Windows.Forms.RadioButton();
            this.Rbtn20 = new System.Windows.Forms.RadioButton();
            this.Rbtn100 = new System.Windows.Forms.RadioButton();
            this.Rbtn70 = new System.Windows.Forms.RadioButton();
            this.RbtnOtro = new System.Windows.Forms.RadioButton();
            this.Rbtn40 = new System.Windows.Forms.RadioButton();
            this.LblHola = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rbtn10
            // 
            this.Rbtn10.AutoSize = true;
            this.Rbtn10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn10.Location = new System.Drawing.Point(19, 53);
            this.Rbtn10.Name = "Rbtn10";
            this.Rbtn10.Size = new System.Drawing.Size(155, 27);
            this.Rbtn10.TabIndex = 0;
            this.Rbtn10.TabStop = true;
            this.Rbtn10.Text = "$ 10 DOLARES";
            this.Rbtn10.UseVisualStyleBackColor = true;
            this.Rbtn10.CheckedChanged += new System.EventHandler(this.Rbtn10_CheckedChanged);
            // 
            // Rbtn20
            // 
            this.Rbtn20.AutoSize = true;
            this.Rbtn20.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn20.Location = new System.Drawing.Point(19, 123);
            this.Rbtn20.Name = "Rbtn20";
            this.Rbtn20.Size = new System.Drawing.Size(155, 27);
            this.Rbtn20.TabIndex = 1;
            this.Rbtn20.TabStop = true;
            this.Rbtn20.Text = "$ 20 DOLARES";
            this.Rbtn20.UseVisualStyleBackColor = true;
            // 
            // Rbtn100
            // 
            this.Rbtn100.AutoSize = true;
            this.Rbtn100.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn100.Location = new System.Drawing.Point(291, 123);
            this.Rbtn100.Name = "Rbtn100";
            this.Rbtn100.Size = new System.Drawing.Size(166, 27);
            this.Rbtn100.TabIndex = 3;
            this.Rbtn100.TabStop = true;
            this.Rbtn100.Text = "$ 100 DOLARES";
            this.Rbtn100.UseVisualStyleBackColor = true;
            // 
            // Rbtn70
            // 
            this.Rbtn70.AutoSize = true;
            this.Rbtn70.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn70.Location = new System.Drawing.Point(291, 53);
            this.Rbtn70.Name = "Rbtn70";
            this.Rbtn70.Size = new System.Drawing.Size(155, 27);
            this.Rbtn70.TabIndex = 2;
            this.Rbtn70.TabStop = true;
            this.Rbtn70.Text = "$ 70 DOLARES";
            this.Rbtn70.UseVisualStyleBackColor = true;
            // 
            // RbtnOtro
            // 
            this.RbtnOtro.AutoSize = true;
            this.RbtnOtro.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnOtro.Location = new System.Drawing.Point(291, 196);
            this.RbtnOtro.Name = "RbtnOtro";
            this.RbtnOtro.Size = new System.Drawing.Size(115, 27);
            this.RbtnOtro.TabIndex = 5;
            this.RbtnOtro.TabStop = true;
            this.RbtnOtro.Text = "Otro valor";
            this.RbtnOtro.UseVisualStyleBackColor = true;
            // 
            // Rbtn40
            // 
            this.Rbtn40.AutoSize = true;
            this.Rbtn40.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn40.Location = new System.Drawing.Point(19, 196);
            this.Rbtn40.Name = "Rbtn40";
            this.Rbtn40.Size = new System.Drawing.Size(155, 27);
            this.Rbtn40.TabIndex = 4;
            this.Rbtn40.TabStop = true;
            this.Rbtn40.Text = "$ 40 DOLARES";
            this.Rbtn40.UseVisualStyleBackColor = true;
            // 
            // LblHola
            // 
            this.LblHola.AutoSize = true;
            this.LblHola.BackColor = System.Drawing.Color.Transparent;
            this.LblHola.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHola.Location = new System.Drawing.Point(73, 9);
            this.LblHola.Name = "LblHola";
            this.LblHola.Size = new System.Drawing.Size(302, 28);
            this.LblHola.TabIndex = 6;
            this.LblHola.Text = "Sleccione el valor a retirar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cajero_Automatico.Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 271);
            this.Controls.Add(this.LblHola);
            this.Controls.Add(this.RbtnOtro);
            this.Controls.Add(this.Rbtn40);
            this.Controls.Add(this.Rbtn100);
            this.Controls.Add(this.Rbtn70);
            this.Controls.Add(this.Rbtn20);
            this.Controls.Add(this.Rbtn10);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRetirar";
            this.Text = "Ritirar Cuenta Ahorro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rbtn10;
        private System.Windows.Forms.RadioButton Rbtn20;
        private System.Windows.Forms.RadioButton Rbtn100;
        private System.Windows.Forms.RadioButton Rbtn70;
        private System.Windows.Forms.RadioButton RbtnOtro;
        private System.Windows.Forms.RadioButton Rbtn40;
        private System.Windows.Forms.Label LblHola;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}