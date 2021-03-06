namespace ProjetoPastelaria
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelConfigJuros = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelConfigMulta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelConfigLinguagem = new System.Windows.Forms.Label();
            this.comboBoxLinguagem = new System.Windows.Forms.ComboBox();
            this.buttonConfigSalvar = new System.Windows.Forms.Button();
            this.checkBoxAlteraIdioma = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.textBoxStringDeConexao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfigJuros
            // 
            this.labelConfigJuros.AutoSize = true;
            this.labelConfigJuros.Location = new System.Drawing.Point(3, 44);
            this.labelConfigJuros.Name = "labelConfigJuros";
            this.labelConfigJuros.Size = new System.Drawing.Size(76, 15);
            this.labelConfigJuros.TabIndex = 36;
            this.labelConfigJuros.Text = "Percent juros";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(148, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelConfigMulta
            // 
            this.labelConfigMulta.AutoSize = true;
            this.labelConfigMulta.Location = new System.Drawing.Point(310, 44);
            this.labelConfigMulta.Name = "labelConfigMulta";
            this.labelConfigMulta.Size = new System.Drawing.Size(72, 15);
            this.labelConfigMulta.TabIndex = 34;
            this.labelConfigMulta.Text = "Multa por at";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(444, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 23);
            this.textBox2.TabIndex = 2;
            // 
            // labelConfigLinguagem
            // 
            this.labelConfigLinguagem.AutoSize = true;
            this.labelConfigLinguagem.Location = new System.Drawing.Point(3, 100);
            this.labelConfigLinguagem.Name = "labelConfigLinguagem";
            this.labelConfigLinguagem.Size = new System.Drawing.Size(30, 15);
            this.labelConfigLinguagem.TabIndex = 41;
            this.labelConfigLinguagem.Text = "Ling";
            // 
            // comboBoxLinguagem
            // 
            this.comboBoxLinguagem.BackColor = System.Drawing.Color.White;
            this.comboBoxLinguagem.FormattingEnabled = true;
            this.comboBoxLinguagem.Items.AddRange(new object[] {
            "pt-BR",
            "en-US",
            "es"});
            this.comboBoxLinguagem.Location = new System.Drawing.Point(145, 95);
            this.comboBoxLinguagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLinguagem.Name = "comboBoxLinguagem";
            this.comboBoxLinguagem.Size = new System.Drawing.Size(144, 23);
            this.comboBoxLinguagem.TabIndex = 3;
            // 
            // buttonConfigSalvar
            // 
            this.buttonConfigSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigSalvar.Location = new System.Drawing.Point(602, 205);
            this.buttonConfigSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfigSalvar.Name = "buttonConfigSalvar";
            this.buttonConfigSalvar.Size = new System.Drawing.Size(83, 22);
            this.buttonConfigSalvar.TabIndex = 43;
            this.buttonConfigSalvar.Text = "Salvar";
            this.buttonConfigSalvar.UseVisualStyleBackColor = true;
            this.buttonConfigSalvar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // checkBoxAlteraIdioma
            // 
            this.checkBoxAlteraIdioma.AutoSize = true;
            this.checkBoxAlteraIdioma.Location = new System.Drawing.Point(310, 99);
            this.checkBoxAlteraIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAlteraIdioma.Name = "checkBoxAlteraIdioma";
            this.checkBoxAlteraIdioma.Size = new System.Drawing.Size(123, 19);
            this.checkBoxAlteraIdioma.TabIndex = 4;
            this.checkBoxAlteraIdioma.Text = "Alterar ja o idioma";
            this.checkBoxAlteraIdioma.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(447, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 1);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(149, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 1);
            this.panel2.TabIndex = 45;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(855, 41);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(190, 23);
            this.comboBoxProvider.TabIndex = 46;
            // 
            // textBoxStringDeConexao
            // 
            this.textBoxStringDeConexao.Location = new System.Drawing.Point(855, 95);
            this.textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            this.textBoxStringDeConexao.Size = new System.Drawing.Size(190, 23);
            this.textBoxStringDeConexao.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(915, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 22);
            this.button1.TabIndex = 48;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 22);
            this.button2.TabIndex = 49;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStringDeConexao);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxAlteraIdioma);
            this.Controls.Add(this.buttonConfigSalvar);
            this.Controls.Add(this.labelConfigLinguagem);
            this.Controls.Add(this.comboBoxLinguagem);
            this.Controls.Add(this.labelConfigJuros);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelConfigMulta);
            this.Controls.Add(this.textBox2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
            this.Load += new System.EventHandler(this.Config_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Config_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelConfigJuros;
        private TextBox textBox1;
        private Label labelConfigMulta;
        private TextBox textBox2;
        private Label labelConfigLinguagem;
        private ComboBox comboBoxLinguagem;
        private Button buttonConfigSalvar;
        private CheckBox checkBoxAlteraIdioma;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBoxProvider;
        private TextBox textBoxStringDeConexao;
        private Button button1;
        private Button button2;
    }
}