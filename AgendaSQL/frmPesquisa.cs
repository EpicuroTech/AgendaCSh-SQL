using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmPesquisa : Form
    {
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }
        public frmPesquisa()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fecha o quadro, cancelando a pesquisa
            cancelado = true;
            this.Close();
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //executa a pesquisa apenas se houver texto na textbox
            if (textBox_pesquisa.Text == "") cancelado = true;
            else texto_pesquisa = textBox_pesquisa.Text;
            this.Close();
        }
    }
}
