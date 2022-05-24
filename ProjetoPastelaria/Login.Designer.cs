namespace ProjetoPastelaria
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.buttonLoginEntrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(79, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(79, 137);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 16);
            this.textBox2.TabIndex = 1;
            this.textBox2.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.TextBox2_Leave);
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoginUser.Location = new System.Drawing.Point(21, 56);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(27, 15);
            this.labelLoginUser.TabIndex = 2;
            this.labelLoginUser.Text = "Usu";
            // 
            // labelLoginSenha
            // 
            this.labelLoginSenha.AutoSize = true;
            this.labelLoginSenha.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoginSenha.Location = new System.Drawing.Point(21, 137);
            this.labelLoginSenha.Name = "labelLoginSenha";
            this.labelLoginSenha.Size = new System.Drawing.Size(19, 15);
            this.labelLoginSenha.TabIndex = 3;
            this.labelLoginSenha.Text = "Se";
            // 
            // buttonLoginEntrar
            // 
            this.buttonLoginEntrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLoginEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLoginEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginEntrar.Location = new System.Drawing.Point(95, 209);
            this.buttonLoginEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoginEntrar.Name = "buttonLoginEntrar";
            this.buttonLoginEntrar.Size = new System.Drawing.Size(116, 22);
            this.buttonLoginEntrar.TabIndex = 4;
            this.buttonLoginEntrar.Text = "Ent";
            this.buttonLoginEntrar.UseVisualStyleBackColor = false;
            this.buttonLoginEntrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelLoginUser);
            this.panel1.Controls.Add(this.labelLoginSenha);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buttonLoginEntrar);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 253);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(79, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(79, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 1);
            this.panel2.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(292, 250);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelLoginUser;
        private Label labelLoginSenha;
        private Button buttonLoginEntrar;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}