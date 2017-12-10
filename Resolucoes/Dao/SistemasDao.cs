using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Resolucoes.Model;
using System.Data;
using Resolucoes.Util;
using System.Windows.Forms;
using System.Collections;

namespace Resolucoes.Dao
{
    class SistemasDao : IDaoPadrao
    {
        SqlCommand cmd;

        //METODO ATUALIZAR
        public bool Atualizar(object obj, int tabela)
        {
            string table = VerificaTabela(tabela);

            bool retorno = false;
            string sql = "update " + table + " set assunto=@assunto, descricao=@descricao," +
                "dataGravacao=@data, quemGravou=@quemGravou where codigo=@cod";

            try
            {
                Conexao.conn.Open();
                using (cmd = new SqlCommand(sql, Conexao.conn))
                {
                    Sistemas s = new Sistemas();
                    s = (Sistemas)obj;
                    cmd.Parameters.Add("@assunto", SqlDbType.VarChar).Value = s.Assunto;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = s.Descricao;
                    cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime).Value = s.DataUltimaGravacao;
                    //cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime).Value = m.DataUltimaGravacao;
                    cmd.Parameters.Add("@quemGravou", SqlDbType.VarChar).Value = s.QuemGravou;
                    cmd.Parameters.Add("@cod", SqlDbType.Int).Value = s.Codigo;

                    cmd.ExecuteNonQuery();
                    Conexao.conn.Close();
                    retorno = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao verificar banco de dados !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.conn.Close();
            }
            return retorno;
        }

        //METODO INSERIR
        public bool Inserir(object obj, int tabela)
        {
            string table = VerificaTabela(tabela);

            bool retorno = false;
            string sql = "insert into " + table + " (assunto,descricao,dataGravacao,quemGravou)" +
               " values(@assunto,@descricao,@data,@userName)";

            try
            {
                Conexao.conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, Conexao.conn))
                {
                    //cmd = new SqlCommand(sql);

                    Sistemas m = new Sistemas();
                    m = (Sistemas)obj;

                    cmd.Parameters.Add("@assunto", System.Data.SqlDbType.VarChar).Value = m.Assunto;
                    cmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar).Value = m.Descricao;
                    cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime).Value = m.DataUltimaGravacao;
                    cmd.Parameters.Add("@userName", System.Data.SqlDbType.VarChar).Value = m.QuemGravou;

                    cmd.ExecuteNonQuery();

                    retorno = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao verificar banco de dados !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.conn.Close();
            }
            return retorno;
        }

        //METODO PARA VERIFICAR O ULTIMO REGISTRO NO BANCO
        public int VerificaultimoRegistro(int sistema)
        {
            int ultimo = 0;
            string tabela = VerificaTabela(sistema);

            string sql = "select MAX(codigo) from " + tabela;

            try
            {
                Conexao.conn.Open();
                using (cmd = new SqlCommand(sql, Conexao.conn))
                {
                    //Fazendo a leitura no banco
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        ultimo = rd.GetInt32(0);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao verificar banco de dados !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.conn.Close();
            }
            return ultimo;
        }


        //METODO BUSCARCODIGO
        public object BuscarCodigo(int codigo, int tabela)
        {
            object obj = new object();
            string table = VerificaTabela(tabela);
            string sql = "select *from " + table + " where codigo=@codigo";

            try
            {
                Conexao.conn.Open();
                using (cmd = new SqlCommand(sql, Conexao.conn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        Sistemas s = new Sistemas();
                        s.Codigo = rd.GetInt32(0);
                        s.Assunto = rd.GetString(1);
                        s.Descricao = rd.GetString(2);
                        s.DataUltimaGravacao = rd.GetDateTime(3);
                        s.QuemGravou = rd.GetString(4);
                        obj = s;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao verificar banco de dados !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.conn.Close();
            }
            return obj;
        }

        //METODO BUSCAR ASSUNTO
        public List<Sistemas> BuscarAssunto(string assunto, int tabela)
        {
            var listaSis = new List<Sistemas>();

            string table = VerificaTabela(tabela);
            string sql = "select *from " + table + " where assunto like @assunto";

            try
            {
                Conexao.conn.Open();
                using (cmd = new SqlCommand(sql, Conexao.conn))
                {
                    cmd.Parameters.Add("@assunto", SqlDbType.VarChar).Value = assunto;

                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        Sistemas s = new Sistemas();
                        s.Codigo = rd.GetInt32(0);
                        s.Assunto = rd.GetString(1);
                        s.Descricao = rd.GetString(2);
                        s.DataUltimaGravacao = rd.GetDateTime(3);
                        s.QuemGravou = rd.GetString(4);

                        listaSis.Add(s);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao verificar banco de dados !","Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.conn.Close();
            }
            return listaSis;
        }

        //VERIFICA EM QUAL TABELA DO BANCO SERÁ EXECUTADA A INSTRUÇÃO SQL
        public string VerificaTabela(int table)
        {
            string tabela = "";
            switch (table)
            {
                case 1:
                    tabela = "misterchef";
                    break;
                case 2:
                    tabela = "chefweb";
                    break;
                case 3:
                    tabela = "tef";
                    break;
            }

            return tabela;
        }

        //VERIFICA CONFIGURAÇÕES
        public Configuracoes VerificaConfiguracoes()
        {
            Configuracoes config = null;
            string sql = "select *from configuracoes";
            try
            {
                Conexao.conn.Open();
                using (cmd = new SqlCommand(sql, Conexao.conn))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        config = new Configuracoes();
                        config.Aplicacao = rd.GetString(0);
                        config.Versao = rd.GetString(1);
                        config.Email = rd.GetString(2);
                        config.Menssagem = rd.GetString(3);
                        config.linkNovaVersao = rd.GetString(4);
                    }
                }
            }
            catch (Exception)
            {
                config = null;
                MessageBox.Show("Erro ao verificar configurações no banco", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.conn.Close();
            }

            return config;
        }


    }
}
