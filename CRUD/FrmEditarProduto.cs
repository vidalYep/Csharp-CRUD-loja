using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FrmEditarProduto : Form
    {   

     

        int id;
        bool excluir = false;
        produto produto = new produto();

        public FrmEditarProduto(int id, bool excluir = false)
        {
            InitializeComponent();
            this.id = id;
            this.excluir = excluir;

            if (this.id > 0)
            {
                produto.GetProduto(this.id);

                txt_id.Text = produto.Id.ToString();
                txt_codigo.Text = produto.Codigo;
                txt_nome.Text = produto.Nome;
                txt_fornecedor.Text = produto.Fornecedor_nome;
                txt_preco.Text = produto.Preco.ToString("N2");
                txt_quantidade.Text = produto.Quantidade.ToString();

                if (produto.Ativo == 's')
                    chk_ativo.Checked = true;
                else
                    chk_ativo.Checked = false;

            }

            if (this.excluir)
            {
                TravarForm();
                btn_salvar.Visible = false;
                btn_excluir.Visible = true;
            }
        }

        private void TravarForm()
        {
            txt_id.Enabled = false;
            txt_codigo.Enabled = false;
            txt_nome.Enabled = false;
            txt_fornecedor.Enabled = false;
            txt_preco.Enabled = false;
            txt_quantidade.Enabled = false;
            chk_ativo.Enabled = false;


        }

        private void FrmEditarProduto_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                produto.Codigo = txt_codigo.Text;
                produto.Nome = txt_nome.Text;
                produto.Fornecedor_nome = txt_fornecedor.Text;
                produto.Preco = Convert.ToDecimal("0" + txt_preco.Text);
                produto.Quantidade = Convert.ToInt32("0" + txt_quantidade.Text);

                if (chk_ativo.Checked == true)
                {
                    produto.Ativo = 's';
                }
                else
                {
                    produto.Ativo = 'n';
                }

                produto.SalvarProduto();
                this.Close();
            }
        }

        //VALIDAÇÃO DO FORMS PARA QUE NÃO SEJA INSERIDO VALORES NULL NAS TEXTBOX
        private bool validar()
        {
            //CODIGO

            if (txt_codigo.Text == "")
            {
                MessageBox.Show("O produto precisa de um código.", Program.sistema);
                txt_codigo.Focus();
                return false;
            }

            //NOME

            else if (txt_nome.Text == "")
            {
                MessageBox.Show("O produto precisa de um nome.", Program.sistema);
                txt_nome.Focus();
                return false;
            }

            //FORNECEDOR

            else if (txt_fornecedor.Text == "")
            {
                MessageBox.Show("O produto precisa do nome do fornecedor.", Program.sistema);
                txt_fornecedor.Focus();
                return false;
            }

            //PRECO

            else if (txt_preco.Text == "")
            {
                MessageBox.Show("O produto precisa de um preço.", Program.sistema);
                txt_preco.Focus();
                return false;
            }

            //QUANTIDADE

            else if (txt_quantidade.Text == "")
            {
                MessageBox.Show("O produto precisa de uma quantidade.", Program.sistema);
                txt_quantidade.Focus();
                return false;
            }


            return true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            produto.Excluir();
            this.Close();
        }
    }
}
