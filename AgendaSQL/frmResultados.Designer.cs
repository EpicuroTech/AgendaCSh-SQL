namespace AgendaSQL
{
    partial class frmResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.grelha_resultados = new System.Windows.Forms.DataGridView();
            this.label_resultados = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_vertudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(572, 403);
            this.cmd_fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(163, 58);
            this.cmd_fechar.TabIndex = 2;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // grelha_resultados
            // 
            this.grelha_resultados.AllowUserToAddRows = false;
            this.grelha_resultados.AllowUserToDeleteRows = false;
            this.grelha_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha_resultados.Location = new System.Drawing.Point(23, 44);
            this.grelha_resultados.MultiSelect = false;
            this.grelha_resultados.Name = "grelha_resultados";
            this.grelha_resultados.ReadOnly = true;
            this.grelha_resultados.RowHeadersVisible = false;
            this.grelha_resultados.RowHeadersWidth = 62;
            this.grelha_resultados.RowTemplate.Height = 28;
            this.grelha_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_resultados.Size = new System.Drawing.Size(712, 338);
            this.grelha_resultados.TabIndex = 3;
            this.grelha_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_resultados_CellClick);
            // 
            // label_resultados
            // 
            this.label_resultados.AutoSize = true;
            this.label_resultados.Location = new System.Drawing.Point(19, 21);
            this.label_resultados.Name = "label_resultados";
            this.label_resultados.Size = new System.Drawing.Size(51, 20);
            this.label_resultados.TabIndex = 4;
            this.label_resultados.Text = "label1";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(386, 403);
            this.cmd_apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(163, 58);
            this.cmd_apagar.TabIndex = 5;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(204, 403);
            this.cmd_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(163, 58);
            this.cmd_editar.TabIndex = 6;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_vertudo
            // 
            this.cmd_vertudo.Location = new System.Drawing.Point(23, 403);
            this.cmd_vertudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_vertudo.Name = "cmd_vertudo";
            this.cmd_vertudo.Size = new System.Drawing.Size(163, 58);
            this.cmd_vertudo.TabIndex = 7;
            this.cmd_vertudo.Text = "Atualizar";
            this.cmd_vertudo.UseVisualStyleBackColor = true;
            this.cmd_vertudo.Click += new System.EventHandler(this.cmd_vertudo_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 496);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_vertudo);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_resultados);
            this.Controls.Add(this.grelha_resultados);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados da Pesquisa";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.DataGridView grelha_resultados;
        private System.Windows.Forms.Label label_resultados;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_vertudo;
    }
}