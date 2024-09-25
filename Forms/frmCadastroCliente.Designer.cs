namespace devPOO.Forms
{
    partial class frmCadastroCliente
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
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.numIdCliente = new System.Windows.Forms.NumericUpDown();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.numRendaCliente = new System.Windows.Forms.NumericUpDown();
            this.maskTipoDocumento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCPF = new System.Windows.Forms.RadioButton();
            this.radioCNPJ = new System.Windows.Forms.RadioButton();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRendaCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(39, 104);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(168, 20);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // numIdCliente
            // 
            this.numIdCliente.Location = new System.Drawing.Point(39, 56);
            this.numIdCliente.Name = "numIdCliente";
            this.numIdCliente.Size = new System.Drawing.Size(168, 20);
            this.numIdCliente.TabIndex = 1;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(39, 153);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(168, 20);
            this.txtEnderecoCliente.TabIndex = 5;
            // 
            // numRendaCliente
            // 
            this.numRendaCliente.DecimalPlaces = 2;
            this.numRendaCliente.Location = new System.Drawing.Point(39, 201);
            this.numRendaCliente.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numRendaCliente.Name = "numRendaCliente";
            this.numRendaCliente.Size = new System.Drawing.Size(168, 20);
            this.numRendaCliente.TabIndex = 7;
            // 
            // maskTipoDocumento
            // 
            this.maskTipoDocumento.Location = new System.Drawing.Point(39, 317);
            this.maskTipoDocumento.Mask = "000.000.000-00";
            this.maskTipoDocumento.Name = "maskTipoDocumento";
            this.maskTipoDocumento.Size = new System.Drawing.Size(168, 20);
            this.maskTipoDocumento.TabIndex = 10;
            this.maskTipoDocumento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Renda:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(39, 362);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(81, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(126, 362);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(81, 23);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Ler";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(39, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelTipoDocumento);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.numIdCliente);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtEnderecoCliente);
            this.groupBox1.Controls.Add(this.numRendaCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskTipoDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioCPF);
            this.groupBox2.Controls.Add(this.radioCNPJ);
            this.groupBox2.Location = new System.Drawing.Point(39, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo do documento:";
            // 
            // radioCPF
            // 
            this.radioCPF.AutoSize = true;
            this.radioCPF.Checked = true;
            this.radioCPF.Location = new System.Drawing.Point(28, 22);
            this.radioCPF.Name = "radioCPF";
            this.radioCPF.Size = new System.Drawing.Size(45, 17);
            this.radioCPF.TabIndex = 0;
            this.radioCPF.TabStop = true;
            this.radioCPF.Text = "CPF";
            this.radioCPF.UseVisualStyleBackColor = true;
            this.radioCPF.CheckedChanged += new System.EventHandler(this.radioCPF_CheckedChanged);
            // 
            // radioCNPJ
            // 
            this.radioCNPJ.AutoSize = true;
            this.radioCNPJ.Location = new System.Drawing.Point(89, 22);
            this.radioCNPJ.Name = "radioCNPJ";
            this.radioCNPJ.Size = new System.Drawing.Size(52, 17);
            this.radioCNPJ.TabIndex = 1;
            this.radioCNPJ.Text = "CNPJ";
            this.radioCNPJ.UseVisualStyleBackColor = true;
            this.radioCNPJ.CheckedChanged += new System.EventHandler(this.radioCNPJ_CheckedChanged);
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(36, 301);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(30, 13);
            this.labelTipoDocumento.TabIndex = 9;
            this.labelTipoDocumento.Text = "CPF:";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar: Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroCliente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numIdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRendaCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.NumericUpDown numIdCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.NumericUpDown numRendaCliente;
        private System.Windows.Forms.MaskedTextBox maskTipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioCPF;
        private System.Windows.Forms.RadioButton radioCNPJ;
    }
}