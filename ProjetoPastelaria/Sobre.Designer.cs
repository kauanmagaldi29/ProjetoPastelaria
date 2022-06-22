namespace ProjetoPastelaria
{
    partial class Sobre
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
            this.buttonSobreVoltar = new System.Windows.Forms.Button();
            this.labelSobreNome = new System.Windows.Forms.Label();
            this.linkLabelSobreLink = new System.Windows.Forms.LinkLabel();
            this.richTextBoxSobreTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSobreVoltar
            // 
            this.buttonSobreVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSobreVoltar.Location = new System.Drawing.Point(11, 322);
            this.buttonSobreVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSobreVoltar.Name = "buttonSobreVoltar";
            this.buttonSobreVoltar.Size = new System.Drawing.Size(83, 22);
            this.buttonSobreVoltar.TabIndex = 4;
            this.buttonSobreVoltar.Text = "Voltar";
            this.buttonSobreVoltar.UseVisualStyleBackColor = true;
            this.buttonSobreVoltar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelSobreNome
            // 
            this.labelSobreNome.AutoSize = true;
            this.labelSobreNome.Location = new System.Drawing.Point(11, 5);
            this.labelSobreNome.Name = "labelSobreNome";
            this.labelSobreNome.Size = new System.Drawing.Size(122, 15);
            this.labelSobreNome.TabIndex = 3;
            this.labelSobreNome.Text = "SOBRE O PROGRAMA";
            // 
            // linkLabelSobreLink
            // 
            this.linkLabelSobreLink.AutoSize = true;
            this.linkLabelSobreLink.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelSobreLink.Location = new System.Drawing.Point(454, 5);
            this.linkLabelSobreLink.Name = "linkLabelSobreLink";
            this.linkLabelSobreLink.Size = new System.Drawing.Size(173, 15);
            this.linkLabelSobreLink.TabIndex = 2;
            this.linkLabelSobreLink.TabStop = true;
            this.linkLabelSobreLink.Text = "SAIBA MAIS SOBRE A EMPRESA";
            this.linkLabelSobreLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSobreLink_LinkClicked);
            // 
            // richTextBoxSobreTexto
            // 
            this.richTextBoxSobreTexto.BackColor = System.Drawing.Color.White;
            this.richTextBoxSobreTexto.Location = new System.Drawing.Point(12, 22);
            this.richTextBoxSobreTexto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxSobreTexto.Name = "richTextBoxSobreTexto";
            this.richTextBoxSobreTexto.Size = new System.Drawing.Size(615, 296);
            this.richTextBoxSobreTexto.TabIndex = 0;
            this.richTextBoxSobreTexto.Text = "";
            this.richTextBoxSobreTexto.TextChanged += new System.EventHandler(this.richTextBoxSobreTexto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copyright by: Tiu Zé.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desenvolvido por Kauan Magaldi.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Versão: 1.0.0.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obrigado pela confiança.";
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSobreVoltar);
            this.Controls.Add(this.labelSobreNome);
            this.Controls.Add(this.linkLabelSobreLink);
            this.Controls.Add(this.richTextBoxSobreTexto);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sobre_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonSobreVoltar;
        private Label labelSobreNome;
        private LinkLabel linkLabelSobreLink;
        private RichTextBox richTextBoxSobreTexto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}