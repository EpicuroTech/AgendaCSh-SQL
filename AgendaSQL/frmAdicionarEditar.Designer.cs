namespace AgendaSQL
{
    partial class frmAdicionarEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarEditar));
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_tele = new System.Windows.Forms.TextBox();
            this.label_tele = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(199, 275);
            this.cmd_fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(163, 58);
            this.cmd_fechar.TabIndex = 4;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(368, 275);
            this.cmd_gravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(163, 58);
            this.cmd_gravar.TabIndex = 5;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // label_nome
            // 
            this.label_nome.Location = new System.Drawing.Point(70, 77);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(376, 29);
            this.label_nome.TabIndex = 6;
            this.label_nome.Text = "Nome";
            this.label_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(74, 109);
            this.textBox_nome.MaxLength = 50;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(372, 26);
            this.textBox_nome.TabIndex = 7;
            // 
            // textBox_tele
            // 
            this.textBox_tele.Location = new System.Drawing.Point(74, 186);
            this.textBox_tele.MaxLength = 20;
            this.textBox_tele.Name = "textBox_tele";
            this.textBox_tele.Size = new System.Drawing.Size(230, 26);
            this.textBox_tele.TabIndex = 9;
            // 
            // label_tele
            // 
            this.label_tele.Location = new System.Drawing.Point(70, 154);
            this.label_tele.Name = "label_tele";
            this.label_tele.Size = new System.Drawing.Size(234, 29);
            this.label_tele.TabIndex = 8;
            this.label_tele.Text = "Telefone";
            this.label_tele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 402);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_tele);
            this.Controls.Add(this.label_tele);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar ou Editar";
            this.Load += new System.EventHandler(this.frmAdicionarEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_tele;
        private System.Windows.Forms.Label label_tele;
    }
}