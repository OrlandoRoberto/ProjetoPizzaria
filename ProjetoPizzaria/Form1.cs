using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class Form1 : Form
    {

        //instanciando a clase conexao
        Conexao con = new Conexao();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTamanhoPizza.Items.Add("Pequena");
            cmbTamanhoPizza.Items.Add("Media");
            cmbTamanhoPizza.Items.Add("Grande");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btncalcular_Click(object sender, EventArgs e)
        {//declarando a variavel
            double valorPizza = 0, valorOpcao = 0, valorTotal = 0;

            if (cmbTamanhoPizza.SelectedIndex == 0)
            {
                valorPizza = 20;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 1)
            {
                valorPizza = 30;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 2)
            {
                valorPizza = 50;
            }
            if (chkBorda.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkTempero.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkCebola.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkCatupiry.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            else
            {

            }
            valorTotal = valorPizza + valorOpcao;
            txtValorPizza.Text = Convert.ToString(valorPizza);
            txtValorOpcionais.Text = Convert.ToString(valorOpcao);
            txtValorPagar.Text = Convert.ToString(valorTotal);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValorPiza_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //vefifica os campos
            if (txtValorPizza.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPizza.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tipoPizza,valorPizza,valorOpcao,valorTotal) values(@pizza,@vpizza,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@pizza", MySqlDbType.Text).Value = cmbTamanhoPizza.Text;
                    cmd.Parameters.Add("@vpizza", MySqlDbType.Text).Value = txtValorPizza.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtValorPagar.Text;
                    cmd.ExecuteNonQuery();//ele que grava os dados no banco(executa a acao)

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanhoPizza.Text = "";
                    txtValorPizza.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbTamanhoPizza.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedidos();

        }
    
    //metodo que vai carregar as informações do datagrid
     public void CarregarPedidos()
        {
            try
            {
                txtCodigo.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                cmbTamanhoPizza.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                txtValorPizza.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                txtValorOpcionais.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                txtValorPagar.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erros ao clicar" + error);
            }

        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedido.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //deixa o datagrid limpo
                dgvPedido.DataSource = null;
            }
        }
    }

}