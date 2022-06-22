using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Resources;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPastelariaDoZe_2022.DAO;
using System.Threading.Tasks;
using System.Data.Common;


namespace ProjetoPastelaria
{


    public partial class Comandas : Form
    {

        private readonly ProdutoDAO daoProduto;
        private readonly ComandaDAO dao;

        public Comandas()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model

            dao = new ComandaDAO(provider, strConnection);
            daoProduto = new ProdutoDAO(provider, strConnection);
        }

        private void Comanda_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var comanda = new Comanda
            {
                NumeroComanda = textBox1.Text,
                DataHora = DateTime.Now,
                StatusComanda = 0
            };
            try
            {
                // chama o método para inserir da nossa camada model
                /*
                *NÃO PODE TER OUTRA COMANDA COM MESMO NUMERO E STATUS 0
                * => SE TIVER DAR ALARME, SENÃO ABRIR
                */
                if (!dao.AbreNovaComanda(comanda))
                {
                    MessageBox.Show("ERRO!!! Comanda " + textBox1.Text + " já esta aberta!!!");
                }
                else
                {
                    MessageBox.Show("Comanda aberta com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizaTelaAreaComanda()
        {
            var comanda = new Comanda
            {
                StatusComanda = 0
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.ListaComandas(comanda);
                // seta o data souce com os dados retornados
                dataGridViewComandas.AutoGenerateColumns = true;
                dataGridViewComandas.DataSource = linhas;
                dataGridViewComandas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaItensComanda(int idComanda)
        {
            var comandaProdutos = new ComandaProdutos
            {
                IdComanda = idComanda
            };

            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.ListaItensComanda(comandaProdutos);

                // seta o data source com os dados retornados
                dataGridViewItens.AutoGenerateColumns = true;
                dataGridViewItens.DataSource = linhas;
                dataGridViewItens.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void button2_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
                Nome = textBox2.Text,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = daoProduto.SelectDbProvider(produto);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewProdutos.Columns.Clear();
                dataGridViewProdutos.AutoGenerateColumns = true;
                dataGridViewProdutos.DataSource = linhas;
                dataGridViewProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedCells.Count > 0)
            {
                //pega o ID e o NUMERO da comanda selecionada
                DataGridViewRow selectedRowComanda = dataGridViewComandas.Rows[dataGridViewComandas.SelectedCells[0].RowIndex];
                int idComanda = Convert.ToInt32(selectedRowComanda.Cells[0].Value);
                int numeroComanda = Convert.ToInt32(selectedRowComanda.Cells[1].Value);
                //pega o ID, NOME e VALOR do produto selecionado
                DataGridViewRow selectedRowProduto = dataGridViewProdutos.Rows[dataGridViewProdutos.SelectedCells[0].RowIndex];
                int idProduto = Convert.ToInt32(selectedRowProduto.Cells[0].Value);
                double valorProduto = Convert.ToDouble(selectedRowProduto.Cells[2].Value);
                string nomeProduto = Convert.ToString(selectedRowProduto.Cells[1].Value);
                //abrir tela confirmação e também para indicar a quantidade
                string value = "1";
                if (ClassFuncoes.InputBox("Adicionar " + nomeProduto + " na Comanda: " + numeroComanda, "Quantidade:", ref value) == DialogResult.OK)
                {
                    //Instância objeto
                    var comandaProdutos = new ComandaProdutos
                    {
                        IdComanda = idComanda,
                        IdProduto = idProduto,
                        Quantidade = Convert.ToInt32(value),
                        ValorUnitario = valorProduto,     
                    };
                    try
                    {
                        // chama o metodo para inseir da nossa camada model
                        dao.AddItemComanda(comandaProdutos);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridViewItens_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewComandas.SelectedCells.Count > 0)
            {
                //pega a linha selecionada
                DataGridViewRow selectedRow =

                dataGridViewComandas.Rows[dataGridViewComandas.SelectedCells[0].RowIndex];
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                int idComanda = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizarTelaItensComanda(idComanda);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewItens_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewItens.SelectedCells.Count > 0)
            {
                //pega o ID e o NUMERO da comanda selecionada
                DataGridViewRow selectedRowComanda = dataGridViewComandas.Rows[dataGridViewComandas.SelectedCells[0].RowIndex];
                int idComanda = Convert.ToInt32(selectedRowComanda.Cells[0].Value);
                int numeroComanda = Convert.ToInt32(selectedRowComanda.Cells[1].Value);
                //pega o ID, NOME, QUANTIDADE e VALOR do produto selecionado
                DataGridViewRow selectedRowComandaItens = dataGridViewItens.Rows[dataGridViewItens.SelectedCells[0].RowIndex];
                int idComandaProduto = Convert.ToInt32(selectedRowComandaItens.Cells[0].Value);
                string nomeProduto = Convert.ToString(selectedRowComandaItens.Cells[1].Value);
                string qtdaProduto = Convert.ToString(selectedRowComandaItens.Cells[2].Value);
                double valorProduto = Convert.ToDouble(selectedRowComandaItens.Cells[3].Value);
                //abrir tela confirmação e também para indicar a quantidade
                if (ClassFuncoes.InputBox("Editar " + nomeProduto + " na Comanda: " + numeroComanda, "Quantidade:", ref qtdaProduto) == DialogResult.OK)
                {
                    //Instância objeto
                    var comandaProdutos = new ComandaProdutos
                    {
                        IdComandaProduto = idComandaProduto,
                        Quantidade = Convert.ToInt32(qtdaProduto),
                    };
                    try
                    {
                        // chama o método para inseir da nossa camada model
                        dao.EditaItemComanda(comandaProdutos);
                        AtualizarTelaItensComanda(idComanda);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }


}
