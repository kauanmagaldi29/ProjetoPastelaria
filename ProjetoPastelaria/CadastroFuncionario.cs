using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPastelariaDoZe_2022.DAO;
using System.Configuration;

namespace ProjetoPastelaria
{
    public partial class CadastroFuncionario : Form

    {
        private readonly FuncionarioDAO dao;

        public CadastroFuncionario()
        {
            InitializeComponent();
            labelCadFunID.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunID");
            labelCadFunCPF.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunCPF");
            labelCadFunMatricula.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunMatricula");
            labelCadFunSenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunSenha");
            labelCadFunRsenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunRSenha");
            labelCadFunNome.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunNome");

            textBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox2.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox2.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox3.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox3.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox4.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox4.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox5.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox5.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox6.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox6.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox7.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox7.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

           

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model

            dao = new FuncionarioDAO(provider, strConnection);

        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonVoltar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                //subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    form.Close();
                }
            }
        }


      


        private void CadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
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


        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBox1.Text = row[0].ToString();
                    textBox4.Text = row[1].ToString();
                    textBox2.Text = row[2].ToString();
                    textBox5.Text = row[3].ToString();
                    textBox3.Text = row[5].ToString();


                }
                textBox2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("O campo ID é obrigatório!");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("O campo CPF é obrigatório!");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("O campo Matricula é obrigatório!");
                textBox3.Focus();
                return;
            }

            if (textBox6.Text == "")
            {
                MessageBox.Show("O campo Senha é obrigatório!");
                textBox6.Focus();
                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("O campo Re-senha é obrigatório!");
                textBox7.Focus();
                return;
            }

            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBox4.Text,
                Cpf = textBox2.Text,
                Telefone = textBox5.Text,
                Senha = ClassFuncoes.Sha256Hash(textBox6.Text),
                Matricula = textBox3.Text,
                Grupo = (radioButtonCadFunAdm.Checked) ? 1 : 2,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(funcionario);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarTela();
        }

        private void dataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }


        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
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

            AtualizarTela();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(textBox1.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(funcionario);
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
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(textBox1.Text),
                Nome = textBox4.Text,
                Cpf = textBox2.Text,
                Telefone = textBox5.Text,
                Matricula = textBox3.Text,
                Grupo = (radioButtonCadFunAdm.Checked) ? 1 : 2,

            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(funcionario);
                MessageBox.Show("Dados editados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AtualizarTela();
        }
    }
}
