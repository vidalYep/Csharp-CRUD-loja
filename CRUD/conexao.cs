using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class conexao
    {
        static private string servidor = "localhost";
        static private string banco = "csharp_crud_lojinha";
        static private string usuario = "root";
        static private string senha = "";

        static public string strConn = "server=" + servidor + "; User Id=" + usuario + ";database=" + banco + "; password=" + senha;
    }
}
