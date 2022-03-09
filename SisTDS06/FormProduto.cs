using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisTDS06
{
    public partial class FormProduto : Form
    {
        private readonly object txtId;
        private readonly object id;

        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId2.Text.Trim();
                Produto produto = new Produto();
                produto.Localiza(id);
                txtNome.Text = produto.nome;
                txtValor.Text = Convert.ToString(produto.valor);
                txtQuantidade.Text = Convert.ToString(produto.quantidade);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto.Inserir(txtId2.Text, txtNome.Text, txtQuantidade.Text, txtValor.Text);
                MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> pro = produto.listaproduto();
                dgvProduto.DataSource = pro;
                txtId2.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
             try
            {
                Produto produto = new Produto();
                produto.Atualizar(txtId2.Text, txtNome.Text, txtQuantidade.Text, txtValor.Text);
                MessageBox.Show("Produto atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> pro = produto.listaproduto();
                dgvProduto.DataSource = pro;
                txtId2.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = txtId2.Text.Trim();
                Produto produto = new Produto();
                produto.Exclui(id);
                MessageBox.Show("Produto excluído com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> cli = produto.listaproduto();
                dgvProduto.DataSource = cli;
                txtId2.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            txtId2.Text = "";
            txtNome.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
