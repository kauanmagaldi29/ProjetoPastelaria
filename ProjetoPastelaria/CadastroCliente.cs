using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ProjetoPastelariaDoZe_2022.DAO;

namespace ProjetoPastelaria
{
    public partial class CadastroCliente : Form
    {

        private readonly ClienteDAO dao;
        ///private int buttonVoltar_Click;

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


            userControlCliente.buttonSalvar.Click += ButtonSalvar_Click;
            userControlCliente.buttonVoltar.Click += ButtonVoltar_Click;

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

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
            //Instância e Preenche o objeto com os dados da view
            var Cliente = new Cliente
            {
                IdCliente = 0,
                Nome = textBox5.Text,
                Cpf = maskedTextBox1.Text,
                Telefone = maskedTextBox2.Text,
                Senha = textBox7.Text,
                
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
        }
    }
}
