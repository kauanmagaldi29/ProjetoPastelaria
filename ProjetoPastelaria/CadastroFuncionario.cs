﻿using System;
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

            userControlFuncionario.buttonVoltar.Click += ButtonVoltar_Click;
            userControlFuncionario.buttonSalvar.Click += ButtonSalvar_Click;

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

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void userControlFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBox4.Text,
                Cpf = textBox2.Text,
                Telefone = textBox5.Text,
                Senha = textBox6.Text,
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
        }
    }
}
