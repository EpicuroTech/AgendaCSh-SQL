using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //apresentar a versão do software
            label_versao.Text = vars.versao;
        }
        //------------------------------------------------------------------------
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //sair da app
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }
        //------------------------------------------------------------------------
        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            //abrir form para adicionar novos registos
            frmAdicionarEditar f = new frmAdicionarEditar();
            f.ShowDialog();

        }
        //------------------------------------------------------------------------
        private void cmd_vertudo_Click(object sender, EventArgs e)
        {
            //Abre um quadro para a apresentaçao de resultados
            frmResultados f = new frmResultados();
            f.ShowDialog();
        }
        //------------------------------------------------------------------------
        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //abrir form
            frmPesquisa f = new frmPesquisa();
            f.ShowDialog();

            //cacela a pesquisa se o quadro foi cancelado
            if (f.cancelado)
            {
                f.Dispose();
                return;
            }

            //executa a pesquisa se o quadro nao foi cancelado
            frmResultados ff=new frmResultados(f.texto_pesquisa);
            ff.ShowDialog();
        }

        private void cmd_reset_Click(object sender, EventArgs e)
        {
            //apagar todos os resgistos da base de dados
            if (MessageBox.Show("ATENÇÃO: Deseja eliminar todos os registos da base de dados?",
                                "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

           
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + vars.base_dados);
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contactos", ligacao);
            comando.ExecuteNonQuery();
            ligacao.Dispose();

            //mensagem de conclusao
            MessageBox.Show("Dados eliminados com sucesso.");
        }
    }
}
