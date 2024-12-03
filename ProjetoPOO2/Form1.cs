using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoPOO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            CarregarFornecedores();
            CarregarPedidos();
        }

        private void CarregarProdutos()
        {
            try
            {
                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                string query = "SELECT * FROM Produtos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvProdutos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                int quantidade = int.Parse(txtQuantidade.Text);
                decimal preco = decimal.Parse(txtPreco.Text);

                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                conn.Open();

                string query = "INSERT INTO Produtos (Nome, Quantidade, Preco) VALUES (@Nome, @Quantidade, @Preco)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto adicionado com sucesso!");

                conn.Close();

                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar o produto: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    int idProduto = int.Parse(dgvProdutos.SelectedRows[0].Cells[0].Value.ToString());
                    string nome = txtNome.Text;
                    int quantidade = int.Parse(txtQuantidade.Text);
                    decimal preco = decimal.Parse(txtPreco.Text);

                    MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                    conn.Open();

                    string query = "UPDATE Produtos SET Nome = @Nome, Quantidade = @Quantidade, Preco = @Preco WHERE IdProduto = @IdProduto";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto atualizado com sucesso!");

                    conn.Close();

                    CarregarProdutos();
                }
                else
                {
                    MessageBox.Show("Selecione um produto para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o produto: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int produtoId = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);

                try
                {
                    MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                    conn.Open();

                    string query = "DELETE FROM Produtos WHERE IdProduto = @IdProduto";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdProduto", produtoId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produto excluído com sucesso!");
                        CarregarProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir produto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.GetInstance().CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }


        private void btnLer_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeBusca = txtNome.Text.Trim();
                string quantidadeBusca = txtQuantidade.Text.Trim();
                string precoBusca = txtPreco.Text.Trim();

                string query = "SELECT * FROM Produtos WHERE 1=1";

                if (!string.IsNullOrEmpty(nomeBusca))
                {
                    query += " AND Nome LIKE @Nome";
                }

                if (!string.IsNullOrEmpty(quantidadeBusca))
                {
                    query += " AND Quantidade = @Quantidade";
                }

                if (!string.IsNullOrEmpty(precoBusca))
                {
                    query += " AND Preco = @Preco";
                }

                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(nomeBusca))
                {
                    cmd.Parameters.AddWithValue("@Nome", "%" + nomeBusca + "%");
                }
                if (!string.IsNullOrEmpty(quantidadeBusca))
                {
                    cmd.Parameters.AddWithValue("@Quantidade", int.Parse(quantidadeBusca));
                }
                if (!string.IsNullOrEmpty(precoBusca))
                {
                    cmd.Parameters.AddWithValue("@Preco", decimal.Parse(precoBusca));
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvProdutos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
            }
        }

        private void CarregarFornecedores()
        {
            try
            {
                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                string query = "SELECT * FROM Fornecedores";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvFornecedores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os fornecedores: " + ex.Message);
            }
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeFornecedor.Text;
                string telefone = txtTelefoneFornecedor.Text;

                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                conn.Open();

                string query = "INSERT INTO Fornecedores (Nome, Telefone) VALUES (@Nome, @Telefone)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor adicionado com sucesso!");

                conn.Close();

                CarregarFornecedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar fornecedor: " + ex.Message);
            }
        }


        private void btnLerFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeBusca = txtNomeFornecedor.Text.Trim();
                string telefoneBusca = txtTelefoneFornecedor.Text.Trim();

                string query = "SELECT * FROM Fornecedores WHERE 1=1";

                if (!string.IsNullOrEmpty(nomeBusca))
                {
                    query += " AND Nome LIKE @Nome";
                }

                if (!string.IsNullOrEmpty(telefoneBusca))
                {
                    query += " AND Telefone LIKE @Telefone";
                }

                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(nomeBusca))
                {
                    cmd.Parameters.AddWithValue("@Nome", "%" + nomeBusca + "%");
                }
                if (!string.IsNullOrEmpty(telefoneBusca))
                {
                    cmd.Parameters.AddWithValue("@Telefone", "%" + telefoneBusca + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvFornecedores.DataSource = dt;

                MessageBox.Show("Busca de fornecedores concluída com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar fornecedores: " + ex.Message);
            }
        }


        private void btnAtualizarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedores.SelectedRows.Count > 0)
                {
                    int idFornecedor = int.Parse(dgvFornecedores.SelectedRows[0].Cells[0].Value.ToString()); // ID do fornecedor
                    string nome = txtNomeFornecedor.Text;
                    string telefone = txtTelefoneFornecedor.Text;

                    MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                    conn.Open();

                    string query = "UPDATE Fornecedores SET Nome = @Nome, Telefone = @Telefone WHERE IdFornecedor = @IdFornecedor"; // Use o nome correto da coluna
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@IdFornecedor", idFornecedor);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor atualizado com sucesso!");

                    conn.Close();

                    CarregarFornecedores();
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
            }
        }



        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedores.SelectedRows.Count > 0)
                {
                    int fornecedorId = Convert.ToInt32(dgvFornecedores.SelectedRows[0].Cells[0].Value);

                    MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                    conn.Open();

                    string query = "DELETE FROM Fornecedores WHERE IdFornecedor = @IdFornecedor";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdFornecedor", fornecedorId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor excluído com sucesso!");

                    conn.Close();

                    CarregarFornecedores();
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
            }
        }

        private void CarregarPedidos()
        {
            try
            {
                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                string query = "SELECT IdPedido, DataPedido, Quantidade, IdProduto, IdFornecedor FROM Pedidos";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                System.Data.DataTable dt = new System.Data.DataTable();

                adapter.Fill(dt);

                dgvPedidos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os pedidos: " + ex.Message);
            }
        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DatabaseConnection.GetInstance().Connection;
                DatabaseConnection.GetInstance().OpenConnection();

                string query = "INSERT INTO Pedidos (DataPedido, Quantidade, IdProduto, IdFornecedor) " +
                               "VALUES (@DataPedido, @QuantidadePedido, @IdProduto, @IdFornecedor)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@DataPedido", DataPedido.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@QuantidadePedido", txtQuantidadePedido.Text);
                cmd.Parameters.AddWithValue("@IdProduto", txtIdProdutoFK.Text);
                cmd.Parameters.AddWithValue("@IdFornecedor", txtIdFornecedorFK.Text);

                cmd.ExecuteNonQuery();

                DatabaseConnection.GetInstance().CloseConnection();

                MessageBox.Show("Pedido adicionado com sucesso!");
                CarregarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar pedido: " + ex.Message);
            }


        }

        private void btnAtualizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione um pedido para atualizar.");
                    return;
                }

                int idPedido = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["IdPedido"].Value);

                DatabaseConnection.GetInstance().OpenConnection();

                string query = "UPDATE Pedidos SET DataPedido = @DataPedido, Quantidade = @QuantidadePedido, " +
                               "IdProdutoFK = @IdProduto, IdFornecedorFK = @IdFornecedor WHERE IdPedido = @IdPedido";

                MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetInstance().Connection);

                cmd.Parameters.AddWithValue("@DataPedido", DataPedido.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@QuantidadePedido", txtQuantidadePedido.Text);
                cmd.Parameters.AddWithValue("@IdProduto", txtIdProdutoFK.Text);
                cmd.Parameters.AddWithValue("@IdFornecedor", txtIdFornecedorFK.Text);
                cmd.Parameters.AddWithValue("@IdPedido", idPedido);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Pedido atualizado com sucesso!");
                    CarregarPedidos();
                }
                else
                {
                    MessageBox.Show("Nenhum pedido foi encontrado com o ID fornecido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pedido: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                DatabaseConnection.GetInstance().CloseConnection();
            }
        }

        private void btnExcluirPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione um pedido para excluir.");
                    return;
                }

                int idPedido = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["IdPedido"].Value);

                DatabaseConnection.GetInstance().OpenConnection();

                string query = "DELETE FROM Pedidos WHERE IdPedido = @IdPedido";

                MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetInstance().Connection);
                cmd.Parameters.AddWithValue("@IdPedido", idPedido);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Pedido excluído com sucesso!");
                    CarregarPedidos();
                }
                else
                {
                    MessageBox.Show("Nenhum pedido foi encontrado com o ID fornecido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir pedido: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                DatabaseConnection.GetInstance().CloseConnection();
            }
        }

        private void btnPesquisarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string idProdutoBusca = txtIdProdutoFK.Text.Trim();
                string idFornecedorBusca = txtIdFornecedorFK.Text.Trim();
                string quantidadeBusca = txtQuantidade.Text.Trim();
                string dataPedidoBusca = DataPedido.Value.ToString("yyyy-MM-dd");

                string query = "SELECT * FROM Pedidos WHERE 1=1";

                if (!string.IsNullOrEmpty(idProdutoBusca))
                {
                    query += " AND IdProduto LIKE @IdProduto";
                }
                if (!string.IsNullOrEmpty(idFornecedorBusca))
                {
                    query += " AND IdFornecedor LIKE @IdFornecedor";
                }
                if (!string.IsNullOrEmpty(quantidadeBusca))
                {
                    query += " AND Quantidade LIKE @QuantidadePedido";
                }

                if (chkFiltroData.Checked && DataPedido.Value != DateTime.MinValue)
                {
                    query += " AND DataPedido LIKE @DataPedido";
                }

                DatabaseConnection.GetInstance().OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetInstance().Connection);

              
                if (!string.IsNullOrEmpty(idProdutoBusca))
                {
                    cmd.Parameters.AddWithValue("@IdProduto", "%" + idProdutoBusca + "%");
                }
                if (!string.IsNullOrEmpty(idFornecedorBusca))
                {
                    cmd.Parameters.AddWithValue("@IdFornecedor", "%" + idFornecedorBusca + "%");
                }
                if (!string.IsNullOrEmpty(quantidadeBusca))
                {
                    cmd.Parameters.AddWithValue("@Quantidade", "%" + quantidadeBusca + "%");
                }


                if (chkFiltroData.Checked && DataPedido.Value != DateTime.MinValue)
                {
                    cmd.Parameters.AddWithValue("@DataPedido", "%" + dataPedidoBusca + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPedidos.DataSource = dt;

                DatabaseConnection.GetInstance().CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar pedidos: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNomeFornecedor_Click(object sender, EventArgs e)
        {

        }
    }
}
