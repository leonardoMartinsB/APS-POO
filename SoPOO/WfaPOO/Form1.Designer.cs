namespace WfaPOO
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
            this.grpFormas = new System.Windows.Forms.GroupBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNotificacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpFormas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFormas
            // 
            this.grpFormas.BackColor = System.Drawing.Color.LemonChiffon;
            this.grpFormas.Controls.Add(this.lblNotificacao);
            this.grpFormas.Controls.Add(this.label5);
            this.grpFormas.Controls.Add(this.label4);
            this.grpFormas.Controls.Add(this.label3);
            this.grpFormas.Controls.Add(this.label2);
            this.grpFormas.Controls.Add(this.label1);
            this.grpFormas.Controls.Add(this.txtPerimetro);
            this.grpFormas.Controls.Add(this.lblPerimetro);
            this.grpFormas.Controls.Add(this.txtArea);
            this.grpFormas.Controls.Add(this.lblArea);
            this.grpFormas.Controls.Add(this.cmbObjetos);
            this.grpFormas.Controls.Add(this.btnCriar);
            this.grpFormas.Controls.Add(this.txtRaio);
            this.grpFormas.Controls.Add(this.txtAltura);
            this.grpFormas.Controls.Add(this.txtBase);
            this.grpFormas.Controls.Add(this.lblRaio);
            this.grpFormas.Controls.Add(this.lblAltura);
            this.grpFormas.Controls.Add(this.lblBase);
            this.grpFormas.Controls.Add(this.cmbTriangulo);
            this.grpFormas.Controls.Add(this.cmbForma);
            this.grpFormas.Location = new System.Drawing.Point(62, 74);
            this.grpFormas.Name = "grpFormas";
            this.grpFormas.Size = new System.Drawing.Size(680, 392);
            this.grpFormas.TabIndex = 1;
            this.grpFormas.TabStop = false;
            this.grpFormas.Text = "Fomas Geométricas POO";
            this.grpFormas.Enter += new System.EventHandler(this.grpFormas_Enter);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(423, 306);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(195, 20);
            this.txtPerimetro.TabIndex = 13;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(400, 277);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(243, 13);
            this.lblPerimetro.TabIndex = 12;
            this.lblPerimetro.Text = "Perímetro da forma geométrica escolhida:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(423, 214);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(195, 20);
            this.txtArea.TabIndex = 11;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(419, 190);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(214, 13);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Área da forma geométrica escolhida:";
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(422, 111);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(196, 21);
            this.cmbObjetos.TabIndex = 9;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // txtRaio
            // 
            this.txtRaio.Enabled = false;
            this.txtRaio.Location = new System.Drawing.Point(55, 345);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(112, 20);
            this.txtRaio.TabIndex = 7;
            this.txtRaio.TextChanged += new System.EventHandler(this.txtRaio_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Location = new System.Drawing.Point(56, 277);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(112, 20);
            this.txtAltura.TabIndex = 6;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtBase
            // 
            this.txtBase.Enabled = false;
            this.txtBase.Location = new System.Drawing.Point(56, 217);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(112, 20);
            this.txtBase.TabIndex = 5;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(12, 348);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(37, 13);
            this.lblRaio.TabIndex = 4;
            this.lblRaio.Text = "Raio:";
            this.lblRaio.Click += new System.EventHandler(this.lblRaio_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(10, 280);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(44, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(10, 221);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(39, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base:";
            this.lblBase.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Equilátero",
            "Isósceles",
            "Reto"});
            this.cmbTriangulo.Location = new System.Drawing.Point(9, 135);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(208, 21);
            this.cmbTriangulo.TabIndex = 1;
            this.cmbTriangulo.Visible = false;
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Circunferência",
            "Quadrado",
            "Retângulo",
            "Triângulo"});
            this.cmbForma.Location = new System.Drawing.Point(9, 62);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(208, 21);
            this.cmbForma.TabIndex = 0;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Resultados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Escolha a forma geométrica:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Escolha o tipo da forma geométrica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Informe os dados da forma geométrica:";
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Image = ((System.Drawing.Image)(resources.GetObject("btnCriar.Image")));
            this.btnCriar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCriar.Location = new System.Drawing.Point(229, 260);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(79, 54);
            this.btnCriar.TabIndex = 8;
            this.btnCriar.Text = "Criar";
            this.btnCriar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(349, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 373);
            this.label5.TabIndex = 18;
            this.label5.Text = "--------------------------------------------------------------------";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.AutoSize = true;
            this.lblNotificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacao.Location = new System.Drawing.Point(398, 94);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(238, 13);
            this.lblNotificacao.TabIndex = 19;
            this.lblNotificacao.Text = "Escolha o resultado da forma geométrica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "APS POO | Formas Geométricas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpFormas);
            this.Name = "Form1";
            this.Text = "Calcular Formas Geométricas POO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFormas.ResumeLayout(false);
            this.grpFormas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFormas;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNotificacao;
        private System.Windows.Forms.Label label7;
    }
}

