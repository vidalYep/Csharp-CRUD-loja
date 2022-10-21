using System.ComponentModel;
using System.Data;

namespace CRUD
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            dt = produto.GetProdutos();
            dgv_produtos.DataSource = dt;
            EstiloGradeProduto();
        }

        private void EstiloGradeProduto()
        {
            dgv_produtos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgv_produtos.DefaultCellStyle.Font = new("Arial", 9);
            dgv_produtos.RowHeadersWidth = 25;
            dgv_produtos.Sort(dgv_produtos.Columns["nome"], ListSortDirection.Ascending);

            // COLUNA DO ID 
            dgv_produtos.Columns["id"].HeaderText = "ID";
            dgv_produtos.Columns["id"].Visible = false;

            // COLUNA DO CODIGO
            dgv_produtos.Columns["codigo"].HeaderText = "Código";
            dgv_produtos.Columns["codigo"].Width = 100;

            dgv_produtos.Columns["codigo"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgv_produtos.Columns["codigo"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // COLUNA DO NOME
            dgv_produtos.Columns["nome"].HeaderText = "Nome";
            dgv_produtos.Columns["nome"].Width = 225;

            dgv_produtos.Columns["nome"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgv_produtos.Columns["nome"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // COLUNA DO FORNECEDOR_NOME
            dgv_produtos.Columns["fornecedor_nome"].HeaderText = "Fornecedor";
            dgv_produtos.Columns["fornecedor_nome"].Width = 225;

            dgv_produtos.Columns["fornecedor_nome"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgv_produtos.Columns["fornecedor_nome"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // COLUNA DO PREÇO
            dgv_produtos.Columns["preco"].HeaderText = "Preço";
            dgv_produtos.Columns["preco"].Width = 75;


            dgv_produtos.Columns["preco"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgv_produtos.Columns["preco"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgv_produtos.Columns["preco"].DefaultCellStyle.Format = "N2";

           // COLUNA DA QUANTIDADE
           dgv_produtos.Columns["quantidade"].HeaderText = "Quantidade";
            dgv_produtos.Columns["quantidade"].Width = 75;

            dgv_produtos.Columns["quantidade"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgv_produtos.Columns["quantidade"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            // COLUNA DO ATIVO
            dgv_produtos.Columns["ativo"].HeaderText = "Ativo";
            dgv_produtos.Columns["ativo"].Width = 75;

            dgv_produtos.Columns["ativo"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgv_produtos.Columns["ativo"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgv_produtos.Rows[dgv_produtos.CurrentCell.RowIndex].Cells["id"].Value);

            using (var frm = new FrmEditarProduto(id))
            {
                frm.ShowDialog();
                dgv_produtos.DataSource = produto.GetProdutos();
                EstiloGradeProduto();
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
           
            using (var frm = new FrmEditarProduto(0))
            {
                frm.ShowDialog();
                dgv_produtos.DataSource = produto.GetProdutos();
                EstiloGradeProduto();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dt = produto.GetProdutos(txt_buscar.Text);
            dgv_produtos.DataSource = dt;
            EstiloGradeProduto();
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgv_produtos.Rows[dgv_produtos.CurrentCell.RowIndex].Cells["id"].Value);

            using (var frm = new FrmEditarProduto(id, true))
            {
                frm.ShowDialog();
                dgv_produtos.DataSource = produto.GetProdutos();
                EstiloGradeProduto();
            }
        }
    }
    
}