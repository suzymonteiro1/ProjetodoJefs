
namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtMunicipio = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.MskCep = new System.Windows.Forms.MaskedTextBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.BackgroundImage")));
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(321, 409);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnSalvar.Size = new System.Drawing.Size(121, 62);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(173, 49);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(25, 0, 15, 0);
            this.label1.Size = new System.Drawing.Size(442, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.White;
            this.labelid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelid.Location = new System.Drawing.Point(100, 154);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(21, 17);
            this.labelid.TabIndex = 2;
            this.labelid.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(87, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(76, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(82, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sexo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(52, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Endereço";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(519, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(75, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(542, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(54, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Município";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(525, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Estado";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.White;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Location = new System.Drawing.Point(127, 153);
            this.TxtId.MaxLength = 6;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 0;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEndereco.Location = new System.Drawing.Point(127, 290);
            this.TxtEndereco.MaxLength = 70;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(386, 20);
            this.TxtEndereco.TabIndex = 4;
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Location = new System.Drawing.Point(127, 222);
            this.TxtNome.MaxLength = 70;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(388, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // TxtNumero
            // 
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumero.Location = new System.Drawing.Point(585, 290);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 5;
            // 
            // TxtBairro
            // 
            this.TxtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBairro.Location = new System.Drawing.Point(127, 328);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(386, 20);
            this.TxtBairro.TabIndex = 6;
            // 
            // TxtMunicipio
            // 
            this.TxtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMunicipio.Location = new System.Drawing.Point(127, 365);
            this.TxtMunicipio.MaxLength = 50;
            this.TxtMunicipio.Name = "TxtMunicipio";
            this.TxtMunicipio.Size = new System.Drawing.Size(386, 20);
            this.TxtMunicipio.TabIndex = 8;
            // 
            // TxtEstado
            // 
            this.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEstado.Location = new System.Drawing.Point(585, 365);
            this.TxtEstado.MaxLength = 2;
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(100, 20);
            this.TxtEstado.TabIndex = 9;
            this.TxtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MskCpf
            // 
            this.MskCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCpf.Location = new System.Drawing.Point(127, 186);
            this.MskCpf.Mask = "000.000.000-00";
            this.MskCpf.Name = "MskCpf";
            this.MskCpf.Size = new System.Drawing.Size(100, 23);
            this.MskCpf.TabIndex = 1;
            // 
            // MskCep
            // 
            this.MskCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCep.Location = new System.Drawing.Point(585, 326);
            this.MskCep.Mask = "00000-000";
            this.MskCep.Name = "MskCep";
            this.MskCep.Size = new System.Drawing.Size(100, 23);
            this.MskCep.TabIndex = 7;
            // 
            // CmbSexo
            // 
            this.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.CmbSexo.Location = new System.Drawing.Point(127, 255);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(121, 24);
            this.CmbSexo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 500);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.MskCep);
            this.Controls.Add(this.MskCpf);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.TxtMunicipio);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtMunicipio;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.MaskedTextBox MskCpf;
        private System.Windows.Forms.MaskedTextBox MskCep;
        private System.Windows.Forms.ComboBox CmbSexo;
    }
}

