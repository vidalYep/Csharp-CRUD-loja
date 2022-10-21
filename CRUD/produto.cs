using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Fornecedor_nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public char Ativo { get; set; }
           
        public void GetProduto(int id)
        {
            var sql = "SELECT * FROM produto WHERE id =" + id;

            try
            {
               using (var cn = new MySqlConnection(conexao.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                this.Id = Convert.ToInt32(dr["id"]);
                                this.Codigo = dr["codigo"].ToString();
                                this.Nome = dr["nome"].ToString();
                                this.Fornecedor_nome = dr["fornecedor_nome"].ToString();
                                this.Preco = Convert.ToDecimal(dr["preco"]);
                                this.Quantidade = Convert.ToInt32(dr["quantidade"]);
                                this.Ativo = Convert.ToChar(dr["ativo"]);
                            }
                        }
                    }  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable GetProdutos(string buscar = "")
        {
            var dt = new DataTable();

            var sql = "SELECT id, codigo, nome, fornecedor_nome, preco, quantidade, ativo FROM csharp_crud_lojinha.produto";

            if (buscar != "")
                sql += " WHERE nome LIKE '%" + buscar + "%' OR fornecedor_nome LIKE '%" + buscar + "%' ";
            try
            {
                using (var cn = new MySqlConnection(conexao.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

                
        }

        public void SalvarProduto()
        {
            var sql = "";

            if (this.Id == 0)
                sql = "INSERT INTO produto (codigo, nome, fornecedor_nome, preco, quantidade, ativo) VALUES (@codigo, @nome, @fornecedor_nome, @preco, @quantidade, @ativo)";

            else
                sql = "UPDATE produto SET codigo = @codigo, nome = @nome," +
                    " fornecedor_nome = @fornecedor_nome, preco = @preco, quantidade = @quantidade, ativo = @ativo WHERE id = " + this.Id;

            try
            {
                using (var cn = new MySqlConnection(conexao.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", this.Codigo);
                        cmd.Parameters.AddWithValue("@nome", this.Nome);
                        cmd.Parameters.AddWithValue("@fornecedor_nome", this.Fornecedor_nome);
                        cmd.Parameters.AddWithValue("@preco", this.Preco);
                        cmd.Parameters.AddWithValue("@quantidade", this.Quantidade);
                        cmd.Parameters.AddWithValue("@ativo", this.Ativo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        public void Excluir()
        {
            var sql = "DELETE FROM produto WHERE id=" + this.Id;
            try
            {
                using (var cn = new MySqlConnection(conexao.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
