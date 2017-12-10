namespace Resolucoes
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSistema = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAssunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarRegistro = new System.Windows.Forms.Button();
            this.btnBuscarAssunto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textDataGravacao = new System.Windows.Forms.MaskedTextBox();
            this.textRegistro = new System.Windows.Forms.TextBox();
            this.textSistema = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o sistema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1-TOTVSCHEF     2-CHEF WEB     3-TEF";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(398, 41);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 29);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(467, 44);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(13, 20);
            this.lblSistema.TabIndex = 4;
            this.lblSistema.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Assunto*:";
            // 
            // textAssunto
            // 
            this.textAssunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAssunto.Location = new System.Drawing.Point(220, 81);
            this.textAssunto.MaxLength = 190;
            this.textAssunto.Name = "textAssunto";
            this.textAssunto.Size = new System.Drawing.Size(553, 22);
            this.textAssunto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição*:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(155, 419);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(139, 41);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(322, 419);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(139, 41);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(490, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 41);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarRegistro
            // 
            this.btnBuscarRegistro.Location = new System.Drawing.Point(155, 472);
            this.btnBuscarRegistro.Name = "btnBuscarRegistro";
            this.btnBuscarRegistro.Size = new System.Drawing.Size(184, 41);
            this.btnBuscarRegistro.TabIndex = 15;
            this.btnBuscarRegistro.Text = "BUSCAR REGISTRO";
            this.btnBuscarRegistro.UseVisualStyleBackColor = true;
            this.btnBuscarRegistro.Click += new System.EventHandler(this.btnBuscarRegistro_Click);
            // 
            // btnBuscarAssunto
            // 
            this.btnBuscarAssunto.Location = new System.Drawing.Point(448, 472);
            this.btnBuscarAssunto.Name = "btnBuscarAssunto";
            this.btnBuscarAssunto.Size = new System.Drawing.Size(181, 41);
            this.btnBuscarAssunto.TabIndex = 16;
            this.btnBuscarAssunto.Text = "BUSCAR ASSUNTO";
            this.btnBuscarAssunto.UseVisualStyleBackColor = true;
            this.btnBuscarAssunto.Click += new System.EventHandler(this.btnBuscarAssunto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ultima Gravação:";
            // 
            // textDataGravacao
            // 
            this.textDataGravacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDataGravacao.Location = new System.Drawing.Point(662, 126);
            this.textDataGravacao.Mask = "00/00/0000";
            this.textDataGravacao.Name = "textDataGravacao";
            this.textDataGravacao.Size = new System.Drawing.Size(110, 22);
            this.textDataGravacao.TabIndex = 18;
            this.textDataGravacao.ValidatingType = typeof(System.DateTime);
            // 
            // textRegistro
            // 
            this.textRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegistro.Location = new System.Drawing.Point(79, 84);
            this.textRegistro.Name = "textRegistro";
            this.textRegistro.Size = new System.Drawing.Size(52, 22);
            this.textRegistro.TabIndex = 19;
            this.textRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRegistro_KeyPress);
            // 
            // textSistema
            // 
            this.textSistema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSistema.Location = new System.Drawing.Point(340, 41);
            this.textSistema.Name = "textSistema";
            this.textSistema.Size = new System.Drawing.Size(52, 26);
            this.textSistema.TabIndex = 20;
            this.textSistema.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSistema_KeyDown_1);
            this.textSistema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSistema1_KeyPress);
            // 
            // textDescricao
            // 
            this.textDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescricao.HideSelection = false;
            this.textDescricao.Location = new System.Drawing.Point(16, 151);
            this.textDescricao.MaxLength = 3990;
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescricao.Size = new System.Drawing.Size(756, 262);
            this.textDescricao.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.textSistema);
            this.Controls.Add(this.textRegistro);
            this.Controls.Add(this.textDataGravacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarAssunto);
            this.Controls.Add(this.btnBuscarRegistro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAssunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESOLUÇÕES 1.0.1 - TOTVS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAssunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarRegistro;
        private System.Windows.Forms.Button btnBuscarAssunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox textDataGravacao;
        private System.Windows.Forms.TextBox textRegistro;
        private System.Windows.Forms.TextBox textSistema;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

