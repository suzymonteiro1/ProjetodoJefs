﻿namespace Projeto
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.White;
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Location = new System.Drawing.Point(222, 122);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(385, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(169, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(139, 14);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(80, 0, 40, 0);
            this.label1.Size = new System.Drawing.Size(512, 80);
            this.label1.TabIndex = 58;
            this.label1.Text = "Cadastrar Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCadastrar.BackgroundImage")));
            this.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastrar.Image")));
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrar.Location = new System.Drawing.Point(335, 376);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCadastrar.Size = new System.Drawing.Size(140, 62);
            this.BtnCadastrar.TabIndex = 7;
            this.BtnCadastrar.Text = "&Cadastrar";
            this.BtnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(179, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cpf";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(222, 184);
            this.TxtSenha.MaxLength = 20;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(187, 20);
            this.TxtSenha.TabIndex = 2;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.Location = new System.Drawing.Point(222, 248);
            this.TxtBairro.MaxLength = 70;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(385, 20);
            this.TxtBairro.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(222, 152);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(385, 20);
            this.TxtEmail.TabIndex = 1;
            // 
            // MskCpf
            // 
            this.MskCpf.Location = new System.Drawing.Point(222, 214);
            this.MskCpf.Margin = new System.Windows.Forms.Padding(2);
            this.MskCpf.Mask = "000.000.000-00";
            this.MskCpf.Name = "MskCpf";
            this.MskCpf.Size = new System.Drawing.Size(83, 20);
            this.MskCpf.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(171, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(164, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Senha";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCidade.Location = new System.Drawing.Point(222, 281);
            this.TxtCidade.MaxLength = 70;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(385, 20);
            this.TxtCidade.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(167, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Bairro";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(158, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Cidade";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(158, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Estado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado.Location = new System.Drawing.Point(222, 315);
            this.TxtEstado.MaxLength = 70;
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(385, 20);
            this.TxtEstado.TabIndex = 6;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskCpf);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCadastrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox MskCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEstado;
    }
}