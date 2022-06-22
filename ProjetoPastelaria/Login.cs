namespace ProjetoPastelaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            labelLoginUser.Text = Properties.Resources.ResourceManager.GetString("LabelLoginUser");
            labelLoginSenha.Text = Properties.Resources.ResourceManager.GetString("LabelLoginSenha");
            buttonLoginEntrar.Text = Properties.Resources.ResourceManager.GetString("ButtonLoginEntrar");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("O campo Usuário é obrigatório!");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("O campo Senha é obrigatório!");
                textBox2.Focus();
                return;
            }
            this.Hide();
            Form f = new Menu();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();

        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White; 
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightBlue;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
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
                form.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}