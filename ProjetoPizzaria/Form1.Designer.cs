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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblValorPizaa = new System.Windows.Forms.Label();
            this.lblvalordosOpcionais = new System.Windows.Forms.Label();
            this.lbltotalaPagar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.checkbordaRecheada = new System.Windows.Forms.CheckBox();
            this.checkcebola = new System.Windows.Forms.CheckBox();
            this.checkcatupiry = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.grpboxgrupoOpções = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpboxgrupoOpções.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 129);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblValorPizaa
            // 
            this.lblValorPizaa.AutoSize = true;
            this.lblValorPizaa.Location = new System.Drawing.Point(258, 44);
            this.lblValorPizaa.Name = "lblValorPizaa";
            this.lblValorPizaa.Size = new System.Drawing.Size(74, 13);
            this.lblValorPizaa.TabIndex = 1;
            this.lblValorPizaa.Text = "Valor da Pizza";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(584, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 7;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(391, 203);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(135, 20);
            this.txtPesquisar.TabIndex = 8;
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
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(462, 404);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(81, 22);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
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
            // checkbordaRecheada
            // 
            this.checkbordaRecheada.AutoSize = true;
            this.checkbordaRecheada.Location = new System.Drawing.Point(6, 34);
            this.checkbordaRecheada.Name = "checkbordaRecheada";
            this.checkbordaRecheada.Size = new System.Drawing.Size(107, 17);
            this.checkbordaRecheada.TabIndex = 14;
            this.checkbordaRecheada.Text = "Borda Recheada";
            this.checkbordaRecheada.UseVisualStyleBackColor = true;
            // 
            // checkcebola
            // 
            this.checkcebola.AutoSize = true;
            this.checkcebola.Location = new System.Drawing.Point(6, 71);
            this.checkcebola.Name = "checkcebola";
            this.checkcebola.Size = new System.Drawing.Size(112, 17);
            this.checkcebola.TabIndex = 15;
            this.checkcebola.Text = "Cebola sem Choro";
            this.checkcebola.UseVisualStyleBackColor = true;
            // 
            // checkcatupiry
            // 
            this.checkcatupiry.AutoSize = true;
            this.checkcatupiry.Location = new System.Drawing.Point(6, 99);
            this.checkcatupiry.Name = "checkcatupiry";
            this.checkcatupiry.Size = new System.Drawing.Size(102, 17);
            this.checkcatupiry.TabIndex = 16;
            this.checkcatupiry.Text = "Catupiry Original";
            this.checkcatupiry.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 132);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(108, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Tempero do Chef";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // grpboxgrupoOpções
            // 
            this.grpboxgrupoOpções.Controls.Add(this.checkbordaRecheada);
            this.grpboxgrupoOpções.Controls.Add(this.checkBox4);
            this.grpboxgrupoOpções.Controls.Add(this.checkcebola);
            this.grpboxgrupoOpções.Controls.Add(this.checkcatupiry);
            this.grpboxgrupoOpções.Location = new System.Drawing.Point(12, 84);
            this.grpboxgrupoOpções.Name = "grpboxgrupoOpções";
            this.grpboxgrupoOpções.Size = new System.Drawing.Size(200, 167);
            this.grpboxgrupoOpções.TabIndex = 18;
            this.grpboxgrupoOpções.TabStop = false;
            this.grpboxgrupoOpções.Text = "Escolha Opcionais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxgrupoOpções);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbltotalaPagar);
            this.Controls.Add(this.lblvalordosOpcionais);
            this.Controls.Add(this.lblValorPizaa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpboxgrupoOpções.ResumeLayout(false);
            this.grpboxgrupoOpções.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblValorPizaa;
        private System.Windows.Forms.Label lblvalordosOpcionais;
        private System.Windows.Forms.Label lbltotalaPagar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.CheckBox checkbordaRecheada;
        private System.Windows.Forms.CheckBox checkcebola;
        private System.Windows.Forms.CheckBox checkcatupiry;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox grpboxgrupoOpções;
    }
}

