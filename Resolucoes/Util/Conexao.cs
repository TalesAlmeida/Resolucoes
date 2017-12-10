using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Resolucoes.Util
{
    public static class Conexao
    {
        //CONEXAO COM O BANCO USANDO A STRING DE CONEXAO

        //Acessando banco Local
        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=BASECONHECIMENTO;Integrated Security=True");

        //Acessando o banco no Azure
    }
}
