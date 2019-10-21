namespace frmDALE
{
    partial class frmCadastro
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
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.numAnoFab = new System.Windows.Forms.NumericUpDown();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbcCadastro.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnoFab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.tabPage1);
            this.tbcCadastro.Controls.Add(this.tabPage2);
            this.tbcCadastro.Location = new System.Drawing.Point(1, 1);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(625, 309);
            this.tbcCadastro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.txtPreco);
            this.tabPage2.Controls.Add(this.numAnoFab);
            this.tabPage2.Controls.Add(this.txtCombustivel);
            this.tabPage2.Controls.Add(this.txtChassi);
            this.tabPage2.Controls.Add(this.txtMarca);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.dataFabricacao);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carro";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(198, 239);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(287, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(111, 239);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(24, 239);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(390, 194);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(162, 20);
            this.txtPreco.TabIndex = 11;
            // 
            // numAnoFab
            // 
            this.numAnoFab.Location = new System.Drawing.Point(209, 145);
            this.numAnoFab.Name = "numAnoFab";
            this.numAnoFab.Size = new System.Drawing.Size(82, 20);
            this.numAnoFab.TabIndex = 10;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(209, 194);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(162, 20);
            this.txtCombustivel.TabIndex = 8;
            // 
            // txtChassi
            // 
            this.txtChassi.Enabled = false;
            this.txtChassi.Location = new System.Drawing.Point(24, 194);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(162, 20);
            this.txtChassi.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(24, 99);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(162, 20);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(24, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(47, 20);
            this.txtID.TabIndex = 4;
            // 
            // dataFabricacao
            // 
            this.dataFabricacao.Location = new System.Drawing.Point(235, 34);
            this.dataFabricacao.Name = "dataFabricacao";
            this.dataFabricacao.Size = new System.Drawing.Size(162, 20);
            this.dataFabricacao.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmDALE.Properties.Resources.data;
            this.pictureBox1.Location = new System.Drawing.Point(24, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 311);
            this.Controls.Add(this.tbcCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastro";
            this.Text = "DALE - Cadastro";
            this.tbcCadastro.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnoFab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dataFabricacao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.NumericUpDown numAnoFab;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}