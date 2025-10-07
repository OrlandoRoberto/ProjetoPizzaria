namespace ProjetoPizzaria
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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.lblValorPizzaria = new System.Windows.Forms.Label();
            this.lblvalordosOpcionais = new System.Windows.Forms.Label();
            this.lbltotalaPagar = new System.Windows.Forms.Label();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.grpboxgrupoOpções = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpboxgrupoOpções.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(228, 254);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(450, 129);
            this.dgvPedido.TabIndex = 0;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // lblValorPizzaria
            // 
            this.lblValorPizzaria.AutoSize = true;
            this.lblValorPizzaria.Location = new System.Drawing.Point(258, 44);
            this.lblValorPizzaria.Name = "lblValorPizzaria";
            this.lblValorPizzaria.Size = new System.Drawing.Size(74, 13);
            this.lblValorPizzaria.TabIndex = 1;
            this.lblValorPizzaria.Text = "Valor da Pizza";
            this.lblValorPizzaria.Click += new System.EventHandler(this.lblValorPiza_Click);
            // 
            // lblvalordosOpcionais
            // 
            this.lblvalordosOpcionais.AutoSize = true;
            this.lblvalordosOpcionais.Location = new System.Drawing.Point(409, 44);
            this.lblvalordosOpcionais.Name = "lblvalordosOpcionais";
            this.lblvalordosOpcionais.Size = new System.Drawing.Size(101, 13);
            this.lblvalordosOpcionais.TabIndex = 2;
            this.lblvalordosOpcionais.Text = "Valor dos Opcionais";
            this.lblvalordosOpcionais.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbltotalaPagar
            // 
            this.lbltotalaPagar.AutoSize = true;
            this.lbltotalaPagar.Location = new System.Drawing.Point(581, 44);
            this.lbltotalaPagar.Name = "lbltotalaPagar";
            this.lbltotalaPagar.Size = new System.Drawing.Size(71, 13);
            this.lbltotalaPagar.TabIndex = 3;
            this.lbltotalaPagar.Text = "Total a Pagar";
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(18, 84);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(121, 21);
            this.cmbTamanhoPizza.TabIndex = 4;
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(261, 84);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(85, 20);
            this.txtValorPizza.TabIndex = 5;
            this.txtValorPizza.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(412, 84);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(92, 20);
            this.txtValorOpcionais.TabIndex = 6;
            this.txtValorOpcionais.Text = " ";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(584, 84);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(94, 20);
            this.txtValorPagar.TabIndex = 7;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(391, 203);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(135, 20);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged_1);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(304, 206);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 9;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(238, 404);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(81, 22);
            this.btnnovo.TabIndex = 10;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(356, 404);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(81, 22);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(462, 404);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(81, 22);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(571, 404);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(81, 22);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(6, 34);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(107, 17);
            this.chkBorda.TabIndex = 14;
            this.chkBorda.Text = "Borda Recheada";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 71);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(112, 17);
            this.chkCebola.TabIndex = 15;
            this.chkCebola.Text = "Cebola sem Choro";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(6, 99);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(102, 17);
            this.chkCatupiry.TabIndex = 16;
            this.chkCatupiry.Text = "Catupiry Original";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(6, 132);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(108, 17);
            this.chkTempero.TabIndex = 17;
            this.chkTempero.Text = "Tempero do Chef";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // grpboxgrupoOpções
            // 
            this.grpboxgrupoOpções.Controls.Add(this.chkBorda);
            this.grpboxgrupoOpções.Controls.Add(this.chkTempero);
            this.grpboxgrupoOpções.Controls.Add(this.chkCebola);
            this.grpboxgrupoOpções.Controls.Add(this.chkCatupiry);
            this.grpboxgrupoOpções.Location = new System.Drawing.Point(18, 142);
            this.grpboxgrupoOpções.Name = "grpboxgrupoOpções";
            this.grpboxgrupoOpções.Size = new System.Drawing.Size(200, 167);
            this.grpboxgrupoOpções.TabIndex = 18;
            this.grpboxgrupoOpções.TabStop = false;
            this.grpboxgrupoOpções.Text = "Escolha Opcionais";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(18, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.grpboxgrupoOpções);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.lbltotalaPagar);
            this.Controls.Add(this.lblvalordosOpcionais);
            this.Controls.Add(this.lblValorPizzaria);
            this.Controls.Add(this.dgvPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpboxgrupoOpções.ResumeLayout(false);
            this.grpboxgrupoOpções.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label lblValorPizzaria;
        private System.Windows.Forms.Label lblvalordosOpcionais;
        private System.Windows.Forms.Label lbltotalaPagar;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.GroupBox grpboxgrupoOpções;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

