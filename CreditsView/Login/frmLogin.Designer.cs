﻿namespace CreditsView.Login
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameUsr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.ckbPwd = new System.Windows.Forms.CheckBox();
            this.ckbUsr = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodUsr = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnGetInto = new System.Windows.Forms.Button();
            this.txtIdAcceso = new System.Windows.Forms.TextBox();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNameUsr
            // 
            this.txtNameUsr.Location = new System.Drawing.Point(87, 126);
            this.txtNameUsr.Name = "txtNameUsr";
            this.txtNameUsr.Size = new System.Drawing.Size(236, 20);
            this.txtNameUsr.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CreditsView.Properties.Resources._72b75f9c_72bc_405b_876b_2cef01ddbd90_large;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 212;
            this.label4.Text = "Perfil :";
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(87, 152);
            this.txtProfile.MaxLength = 100;
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.ReadOnly = true;
            this.txtProfile.Size = new System.Drawing.Size(236, 20);
            this.txtProfile.TabIndex = 211;
            // 
            // ckbPwd
            // 
            this.ckbPwd.AutoSize = true;
            this.ckbPwd.ForeColor = System.Drawing.Color.Black;
            this.ckbPwd.Location = new System.Drawing.Point(87, 276);
            this.ckbPwd.Name = "ckbPwd";
            this.ckbPwd.Size = new System.Drawing.Size(119, 17);
            this.ckbPwd.TabIndex = 206;
            this.ckbPwd.Text = "Persistir Contraseña";
            this.ckbPwd.UseVisualStyleBackColor = true;
            // 
            // ckbUsr
            // 
            this.ckbUsr.AutoSize = true;
            this.ckbUsr.ForeColor = System.Drawing.Color.Black;
            this.ckbUsr.Location = new System.Drawing.Point(87, 259);
            this.ckbUsr.Name = "ckbUsr";
            this.ckbUsr.Size = new System.Drawing.Size(101, 17);
            this.ckbUsr.TabIndex = 205;
            this.ckbUsr.Text = "Persistir Usuario";
            this.ckbUsr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 204;
            this.label2.Text = "Contraseña :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 203;
            this.label5.Text = "Usuario :";
            // 
            // txtCodUsr
            // 
            this.txtCodUsr.BackColor = System.Drawing.Color.White;
            this.txtCodUsr.Location = new System.Drawing.Point(87, 178);
            this.txtCodUsr.MaxLength = 100;
            this.txtCodUsr.Name = "txtCodUsr";
            this.txtCodUsr.Size = new System.Drawing.Size(236, 20);
            this.txtCodUsr.TabIndex = 198;
            this.txtCodUsr.Tag = "Usuario";
            this.txtCodUsr.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodUsr_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(207, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 201;
            this.btnCancel.Tag = "3";
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(87, 204);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(235, 20);
            this.txtPwd.TabIndex = 199;
            this.txtPwd.Tag = "Contraseña";
            // 
            // btnGetInto
            // 
            this.btnGetInto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetInto.Location = new System.Drawing.Point(87, 230);
            this.btnGetInto.Name = "btnGetInto";
            this.btnGetInto.Size = new System.Drawing.Size(115, 23);
            this.btnGetInto.TabIndex = 200;
            this.btnGetInto.Tag = "2";
            this.btnGetInto.Text = "Ingresar";
            this.btnGetInto.UseVisualStyleBackColor = true;
            this.btnGetInto.Click += new System.EventHandler(this.btnGetInto_Click);
            // 
            // txtIdAcceso
            // 
            this.txtIdAcceso.Location = new System.Drawing.Point(325, 178);
            this.txtIdAcceso.Name = "txtIdAcceso";
            this.txtIdAcceso.ReadOnly = true;
            this.txtIdAcceso.Size = new System.Drawing.Size(18, 20);
            this.txtIdAcceso.TabIndex = 213;
            this.txtIdAcceso.Visible = false;
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(325, 152);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.ReadOnly = true;
            this.txtCodPerfil.Size = new System.Drawing.Size(18, 20);
            this.txtCodPerfil.TabIndex = 214;
            this.txtCodPerfil.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(359, 316);
            this.ControlBox = false;
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.txtIdAcceso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.ckbPwd);
            this.Controls.Add(this.ckbUsr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodUsr);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.btnGetInto);
            this.Controls.Add(this.txtNameUsr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameUsr;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.CheckBox ckbPwd;
        private System.Windows.Forms.CheckBox ckbUsr;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtCodUsr;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtPwd;
        internal System.Windows.Forms.Button btnGetInto;
        private System.Windows.Forms.TextBox txtIdAcceso;
        private System.Windows.Forms.TextBox txtCodPerfil;
    }
}