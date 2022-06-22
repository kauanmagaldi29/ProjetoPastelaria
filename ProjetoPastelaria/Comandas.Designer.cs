namespace ProjetoPastelaria
{
    partial class Comandas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 72);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(240, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Abrir Comanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(11, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 23);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridViewProdutos);
            this.panel2.Location = new System.Drawing.Point(883, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 529);
            this.panel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(247, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(18, 78);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 23);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar Produto:";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(18, 115);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(394, 402);
            this.dataGridViewProdutos.TabIndex = 9;
            this.dataGridViewProdutos.DoubleClick += new System.EventHandler(this.dataGridViewProdutos_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridViewComandas);
            this.panel3.Location = new System.Drawing.Point(12, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 451);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Comandas Abertas";
            // 
            // dataGridViewComandas
            // 
            this.dataGridViewComandas.AllowUserToDeleteRows = false;
            this.dataGridViewComandas.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandas.Location = new System.Drawing.Point(11, 37);
            this.dataGridViewComandas.MultiSelect = false;
            this.dataGridViewComandas.Name = "dataGridViewComandas";
            this.dataGridViewComandas.RowTemplate.Height = 25;
            this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandas.Size = new System.Drawing.Size(396, 395);
            this.dataGridViewComandas.TabIndex = 10;
            this.dataGridViewComandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewItens);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(446, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 529);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.AllowUserToAddRows = false;
            this.dataGridViewItens.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewItens.Location = new System.Drawing.Point(11, 115);
            this.dataGridViewItens.MultiSelect = false;
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.RowTemplate.Height = 25;
            this.dataGridViewItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItens.Size = new System.Drawing.Size(404, 402);
            this.dataGridViewItens.TabIndex = 11;
            this.dataGridViewItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItens_CellContentClick);
            this.dataGridViewItens.SelectionChanged += new System.EventHandler(this.dataGridViewItens_SelectionChanged);
            this.dataGridViewItens.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewItens_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Itens Comanda";
            // 
            // Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 583);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Comandas";
            this.Text = "Comanda";
            this.Load += new System.EventHandler(this.Comanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private DataGridView dataGridViewProdutos;
        private Panel panel3;
        private Label label3;
        private DataGridView dataGridViewComandas;
        private Panel panel4;
        private DataGridView dataGridViewItens;
        private Label label4;
    }
}