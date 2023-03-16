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
    public partial class frmAdicionarEditar : Form
    {
        int id_contacto;
        bool editar;
        public frmAdicionarEditar(int id_contacto = -1)
        {
            InitializeComponent();
            this.id_contacto = id_contacto;//passar valor vindo por parametro para o id_contacto do form 

            //definir se vou editar ou adicionar novo registo
            //if (id_contacto == -1) { editar = true; }
            //else editar = false;
            editar = id_contacto == -1 ? false : true; //ternario se é = -1 entao false, senao true!

        }

        //---------------------------------------------------------------
        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            //apresenta os dados do contacto se necessário OU SEJA editar = true
            if (editar) ApresentaContacto();
        }
        private void ApresentaContacto() 
        {
            //apresenta contacto
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + vars.base_dados);
            ligacao.Open();
            DataTable dados = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contactos WHERE id_contacto = "+ id_contacto, ligacao);
            adaptador.Fill(dados);
            ligacao.Dispose();

            //colocar os dados na textbox
            textBox_nome.Text = dados.Rows[0]["nome"].ToString();
            textBox_tele.Text = dados.Rows[0]["telefone"].ToString();

        }
        //---------------------------------------------------------------
        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + vars.base_dados);
            ligacao.Open();

            //grava novo ou edita existente

            #region Verificacoes
            //verifica se campos estao preenchidos
            if(textBox_nome.Text == "" || textBox_tele.Text == "")
            {
                MessageBox.Show("Faltam dados.");
                return;
            }

            #endregion

            #region NOVO CONTACTO
            if (!editar)
            {
                //buscar o id_contacto disponivel
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT MAX(id_contacto) AS maxid from contactos", ligacao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //verifica se o valor é null, ainda nao tem dados a bd
                if (DBNull.Value.Equals(dados.Rows[0][0]))//é nulo!
                {
                    id_contacto = 0;
                }
                else  id_contacto = Convert.ToInt16(dados.Rows[0][0]) + 1;//nao é nulo

                //gravar o novo contacto na bd
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;
                //parametros
                comando.Parameters.AddWithValue("@id_contacto", id_contacto);
                comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
                comando.Parameters.AddWithValue("@telefone", textBox_tele.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se já existe um contacto com o mesmo nome e telefone
                adaptador = new SqlCeDataAdapter();
                dados = new DataTable();
                comando.CommandText = "SELECT * FROM contactos WHERE nome = @nome AND telefone = @telefone";
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);
                if (dados.Rows.Count != 0)
                {
                    if(MessageBox.Show("Já existe esse contacto!" + Environment.NewLine + "Quer mesmo duplicar o contacto?",
                        "ATENÇÃO", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No) 
                        return;

                }

                //texto da query
                comando.CommandText = "INSERT INTO contactos VALUES("+
                    "@id_contacto, @nome, @telefone, @atualizacao)";


                //SUSCETIVEL A SQLINJECTION!!!
                //comando.CommandText = 
                //                    "INSERT INTO contactos VALUES(" +
                //                    id_contacto + ", " + 
                //                    "'" + textBox_nome.Text + "', " +
                //                    "'" + textBox_tele.Text + "', " +
                //                    "'2015/02/15')";
                comando.ExecuteNonQuery();
                comando.Dispose();
                ligacao.Dispose();
                MessageBox.Show("Contacto Adicionado!");
                textBox_nome.Text = "";
                textBox_tele.Text = "";
                textBox_nome.Focus();
            }
            #endregion
            //----
            #region EDITAR
            else
            {
                //gravar o novo contacto na bd
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;
                //parametros
                comando.Parameters.AddWithValue("@id_contacto", id_contacto);
                comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
                comando.Parameters.AddWithValue("@telefone", textBox_tele.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se existe registo com o mesmo nome
                DataTable dados = new DataTable();
                comando.CommandText = "SELECT * FROM contactos WHERE nome = @nome AND id_contacto <> @id_contacto";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);
                //ver se já existe
                if (dados.Rows.Count != 0)
                {
                    if (MessageBox.Show("Já existe esse contacto!" + Environment.NewLine + "Quer mesmo editar o contacto?",
                        "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                }
                //editar contacto
                comando.CommandText =   "UPDATE contactos SET " +
                                        "nome = @nome, " +
                                        "telefone = @telefone, " +
                                        "atualizacao = @atualizacao " +
                                        "WHERE id_contacto = @id_contacto";
                comando.ExecuteNonQuery();

                //fecha o formulario
                this.Close();
            }
            #endregion

        }
        //---------------------------------------------------------------
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fecha form currente
            this.Close();
        }
    }
}
