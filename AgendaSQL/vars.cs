using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; //para criação de pastas
using System.Data.SqlServerCe; // para bases de dados SQLCe
using System.Windows.Forms;

namespace AgendaSQL
{
    public static partial class vars
    {
        public static string versao = "v.1.0";
        public static string pasta_dados;
        public static string base_dados;
        //--------------------------------------------------------------------
        public static void Iniciar()
        {
            //iniciar ao abrir aplicação
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSQL\";

            //verifica se a pasta de dados existe, se nao existir, cria a pasta
            if(!Directory.Exists(pasta_dados)) Directory.CreateDirectory(pasta_dados);

            //verifica se a base de dados existe
            base_dados = pasta_dados + "dados.sdf";
            if (!File.Exists(base_dados)) CriarBaseDados();
        }
        //--------------------------------------------------------------------
        //Criaçao base de dados 
        public static void CriarBaseDados()
        {
            MessageBox.Show("Vai ser criada a base de dados!");
            //cria BD
            SqlCeEngine motor = new SqlCeEngine("Data Source = " + base_dados);
            motor.CreateDatabase();

            //abrir ligacao
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + base_dados);
            ligacao.Open();

            //criar tabelas da Base de dados
            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE contactos(" +
                                    "id_contacto            int not null primary key, " +
                                    "nome                   nvarchar(50), " +
                                    "telefone               nvarchar(20), " +
                                    "atualizacao            datetime)";
            comando.Connection = ligacao;
            comando.ExecuteNonQuery();

            //libertar memoria
            comando.Dispose();
            ligacao.Dispose();
        }
    }
}
