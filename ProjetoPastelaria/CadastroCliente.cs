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
    public partial class CadastroCliente : Form
    {

        private readonly ClienteDAO dao;
       

        public CadastroCliente()
        {
            InitializeComponent();

            labelCadCliCPF.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliCPF");
            labelCadCliDias.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliDias");
            labelCadCliFiado.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliFiado");
            labelCadCliNome.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliNome");
            labelCadCliSenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliSenha");
            labelCadCliRSenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliRSenha");
            labelCadCliTelefone.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliTelefone");

            textBox3.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox3.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            textBox5.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox5.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox7.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox7.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox8.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox8.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            comboBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            comboBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            numericUpDown1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            numericUpDown1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new ClienteDAO(provider, strConnection);

        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
           
        }

        private void ButtonVoltar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }


        private void CadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                // subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                //Corrigir
            }
        }



        private void CadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Salvar alteração?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    //
                }
                else
                {
                    //
                }
            }
        }


        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = linhas;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(cliente);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBox3.Text = row[0].ToString();
                    textBox5.Text = row[1].ToString();
                    textBox1.Text = row[2].ToString();
                    textBox2.Text = row[3].ToString();
                    textBox7.Text = row[4].ToString();
                    numericUpDown1.Value = Convert.ToInt32(row[5].ToString());
                    comboBox1.Text = row[6].ToString();


                }
                textBox5.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userControlCliente_Load(object sender, EventArgs e)
        {
          
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
        
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "")
            {
                MessageBox.Show("O campo id é obrigatório!");
                textBox3.Focus();
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("O campo nome é obrigatório!");
                textBox5.Focus();
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("O campo cpf é obrigatório!");
                textBox1.Focus();
                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("O campo senha é obrigatório!");
                textBox7.Focus();
                return;
            }



            //Instância e Preenche o objeto com os dados da view
            var Cliente = new Cliente
            {
                IdCliente = 0,
                Nome = textBox5.Text,
                Cpf = textBox1.Text,
                Telefone = textBox2.Text,
                Senha = ClassFuncoes.Sha256Hash(textBox7.Text)
                
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(Cliente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            AtualizarTela();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                IdCliente = int.Parse(textBox3.Text),
                Nome = textBox5.Text,
                Cpf = textBox1.Text,
                Telefone = textBox2.Text,
                Dia_fiado = numericUpDown1.Text,

            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(cliente);
                MessageBox.Show("Dados editados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AtualizarTela();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                IdCliente = int.Parse(textBox3.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(cliente);
                MessageBox.Show("Dados excluidos com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AtualizarTela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            this.Hide();
            Form f = new Menu();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pega a primeira coluna, que esta com o ID, da linha selecionada
            DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);
            AtualizaTelaEditar(id);
        }
    }
}
