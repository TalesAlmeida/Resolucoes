using Resolucoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucoes.Dao
{
    interface IDaoPadrao
    {
        bool Inserir(Object obj, int tabela);
        bool Atualizar(Object obj, int tabela);
        Object BuscarCodigo(int codigo, int tabela);
        List<Sistemas> BuscarAssunto(string assunto, int tabela);

    }
}
