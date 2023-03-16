namespace AgendaSQL
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label_titulo = new System.Windows.Forms.Label();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_adicionar = new System.Windows.Forms.Button();
            this.cmd_vertudo = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.cmd_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label_titulo.Location = new System.Drawing.Point(141, 24);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(232, 63);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Agenda SQL";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(176, 260);
            this.cmd_pesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(163, 58);
            this.cmd_pesquisar.TabIndex = 3;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(176, 414);
            this.cmd_sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(163, 58);
            this.cmd_sair.TabIndex = 4;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_adicionar
            // 
            this.cmd_adicionar.Location = new System.Drawing.Point(176, 183);
            this.cmd_adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_adicionar.Name = "cmd_adicionar";
            this.cmd_adicionar.Size = new System.Drawing.Size(163, 58);
            this.cmd_adicionar.TabIndex = 2;
            this.cmd_adicionar.Text = "Adicionar";
            this.cmd_adicionar.UseVisualStyleBackColor = true;
            this.cmd_adicionar.Click += new System.EventHandler(this.cmd_adicionar_Click);
            // 
            // cmd_vertudo
            // 
            this.cmd_vertudo.Location = new System.Drawing.Point(176, 106);
            this.cmd_vertudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_vertudo.Name = "cmd_vertudo";
            this.cmd_vertudo.Size = new System.Drawing.Size(163, 58);
            this.cmd_vertudo.TabIndex = 1;
            this.cmd_vertudo.Text = "Visualizar Tudo";
            this.cmd_vertudo.UseVisualStyleBackColor = true;
            this.cmd_vertudo.Click += new System.EventHandler(this.cmd_vertudo_Click);
            // 
            // label_versao
            // 
            this.label_versao.Location = new System.Drawing.Point(224, 491);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(59, 20);
            this.label_versao.TabIndex = 5;
            this.label_versao.Text = "versao";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_reset
            // 
            this.cmd_reset.Location = new System.Drawing.Point(176, 337);
            this.cmd_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_reset.Name = "cmd_reset";
            this.cmd_reset.Size = new System.Drawing.Size(163, 58);
            this.cmd_reset.TabIndex = 6;
            this.cmd_reset.Text = "Reset";
            this.cmd_reset.UseVisualStyleBackColor = true;
            this.cmd_reset.Click += new System.EventHandler(this.cmd_reset_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 606);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_reset);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmd_vertudo);
            this.Controls.Add(this.cmd_adicionar);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "AGENDA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_adicionar;
        private System.Windows.Forms.Button cmd_vertudo;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Button cmd_reset;
    }
}
