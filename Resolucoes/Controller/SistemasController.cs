using Resolucoes.Dao;
using Resolucoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolucoes.Controleler
{
    class SistemasController
    {
        SistemasDao mDao = new SistemasDao();

        //GRAVAR
        public int Gravar(Sistemas m, int tabela)
        {
            int ret = 0;
            bool retDao = false;

            if (m.Assunto.Length < 3 || m.Descricao.Length < 5)
            {
                MessageBox.Show("Assunto ou Descrição inválidos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (m.Codigo == 0)
                    {
                        retDao = mDao.Inserir(m, tabela);
                        if (retDao)
                        {
                            ret = 1;
                        }
                    }
                    else
                    {
                        retDao = mDao.Atualizar(m, tabela);
                        if (retDao)
                        {
                            ret = 2;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro:\n" + ex.Message, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return ret;
        }

        //BUSCAR POR CODIGO
        public Sistemas BuscaCodigo(int codigo, int tabela)
        {
            Sistemas s = null;
            if (codigo < 1)
            {
                MessageBox.Show("Código inválido !");
            }
            else
            {
                try
                {
                    s = (Sistemas)mDao.BuscarCodigo(codigo, tabela);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Não encontrado !\n");
                }
            }

            return s;
        }

        //VERIFICA QUAL O ULTIMO REGISTRO NO BANCO
        public int UltimoRegistro(int tabela)
        {
            int registro = mDao.VerificaultimoRegistro(tabela);

            return registro;
        }

        //BUSCAR POR ASSUNTO
        public List<Sistemas> BuscarAssunto(string assunto, int tabela)
        {
            var lista = new List<Sistemas>();
            if (assunto.Length > 2)
            {
                try
                {
                    SistemasDao sDao = new SistemasDao();

                    lista = sDao.BuscarAssunto("%" + assunto + "%", tabela);
                }
                catch (Exception)
                {

                    MessageBox.Show("Não encontrado !");
                }
            }
            else
            {
                MessageBox.Show("Assunto inválido !");
            }

            return lista;
        }

        //VERIFICA CONFIGURAÇÕES
        public Configuracoes VerificaConfiguracoes()
        {
            var config = mDao.VerificaConfiguracoes();

            return config;
        }

    }
}
