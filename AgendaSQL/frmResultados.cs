using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace AgendaSQL
{
    public partial class frmResultados : Form
    {
        int id_contacto;
        string item_pesquisa;
        public frmResultados(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            ConstruirGrelha();
        }
        //------------------------------------------------------------------------
        private void ConstruirGrelha()
        {
            //constroi grelha

            //ligar a BD
            SqlCeConnection ligacao = new SqlCeConnection("DATA SOURCE = " + vars.base_dados);
            ligacao.Open();

            string query = "SELECT * FROM contactos";
            if(item_pesquisa != "")
            {
                query = "SELECT * FROM contactos WHERE nome LIKE @item OR telefone LIKE @item";
            }
            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@item", "%" + item_pesquisa + "%");
            comando.CommandText= query;
            comando.Connection = ligacao;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //atribui dados á grelha
            grelha_resultados.DataSource = dados;

            //quantidade de resultados
            label_resultados.Text = "Resultados: " + grelha_resultados.Rows.Count;

            //esconder colunas: contacto e atualizaçao
            //grelha_resultados.Columns[0].Visible = false;
            //grelha_resultados.Columns[3].Visible = false;

            //boa pratica usar o nome!
            grelha_resultados.Columns["id_contacto"].Visible = false;
            grelha_resultados.Columns["atualizacao"].Visible = false;

            //alterar as dimensoes das colunas
            grelha_resultados.Columns["nome"].Width = CalcularLargura(70);
            grelha_resultados.Columns["telefone"].Width = CalcularLargura(30);

            //controla a disponibilidade dos comandos
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;

        }
        private int CalcularLargura(int percentagem)
        {
            int largura_grelha = grelha_resultados.Width - 20;
            int resultado = (largura_grelha * percentagem)/100;
            return resultado;
        }
        //------------------------------------------------------------------------
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //apagar a linha selecionada
            SqlCeConnection ligacao = new SqlCeConnection("DATA SOURCE = " + vars.base_dados);
            ligacao.Open();
            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contactos WHERE id_contacto = " + id_contacto, ligacao);
            comando.ExecuteNonQuery();
            comando.Dispose();
            ligacao.Dispose();

            //refresh á grelha
            ConstruirGrelha();
        }
        //------------------------------------------------------------------------
        private void grelha_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contacto = Convert.ToInt16(grelha_resultados.Rows[e.RowIndex].Cells["id_contacto"].Value);
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }
        //------------------------------------------------------------------------
        private void cmd_editar_Click(object sender, EventArgs e)
        {
            //edita contacto
            frmAdicionarEditar f = new frmAdicionarEditar(id_contacto);
            f.ShowDialog();
            //refresh á grelha
            ConstruirGrelha();
        }
        //------------------------------------------------------------------------
        private void cmd_vertudo_Click(object sender, EventArgs e)
        {
            //volta a apresentar todos os registos de contactos
            item_pesquisa = "";
            ConstruirGrelha();
        }
    }
}
