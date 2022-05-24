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
            this.SuspendLayout();
            // 
            // buttonSobreVoltar
            // 
            this.buttonSobreVoltar.Location = new System.Drawing.Point(16, 490);
            this.buttonSobreVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSobreVoltar.Name = "buttonSobreVoltar";
            this.buttonSobreVoltar.Size = new System.Drawing.Size(118, 36);
            this.buttonSobreVoltar.TabIndex = 4;
            this.buttonSobreVoltar.Text = "Voltar";
            this.buttonSobreVoltar.UseVisualStyleBackColor = true;
            this.buttonSobreVoltar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelSobreNome
            // 
            this.labelSobreNome.AutoSize = true;
            this.labelSobreNome.Location = new System.Drawing.Point(16, 9);
            this.labelSobreNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSobreNome.Name = "labelSobreNome";
            this.labelSobreNome.Size = new System.Drawing.Size(124, 25);
            this.labelSobreNome.TabIndex = 3;
            this.labelSobreNome.Text = "PASTEL TIU ZÉ";
            // 
            // linkLabelSobreLink
            // 
            this.linkLabelSobreLink.AutoSize = true;
            this.linkLabelSobreLink.Location = new System.Drawing.Point(671, 9);
            this.linkLabelSobreLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelSobreLink.Name = "linkLabelSobreLink";
            this.linkLabelSobreLink.Size = new System.Drawing.Size(165, 25);
            this.linkLabelSobreLink.TabIndex = 2;
            this.linkLabelSobreLink.TabStop = true;
            this.linkLabelSobreLink.Text = "LINK PASTEL TIU ZÉ";
            // 
            // richTextBoxSobreTexto
            // 
            this.richTextBoxSobreTexto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBoxSobreTexto.Location = new System.Drawing.Point(16, 43);
            this.richTextBoxSobreTexto.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxSobreTexto.Name = "richTextBoxSobreTexto";
            this.richTextBoxSobreTexto.Size = new System.Drawing.Size(820, 439);
            this.richTextBoxSobreTexto.TabIndex = 0;
            this.richTextBoxSobreTexto.Text = "";
            this.richTextBoxSobreTexto.TextChanged += new System.EventHandler(this.richTextBoxSobreTexto_TextChanged);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(849, 532);
            this.Controls.Add(this.buttonSobreVoltar);
            this.Controls.Add(this.labelSobreNome);
            this.Controls.Add(this.linkLabelSobreLink);
            this.Controls.Add(this.richTextBoxSobreTexto);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}