using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLEsportes
{
    public class Conexao
    {
        private static string _server = "localhost";
        private static string _dataBase = "Esportes";
        private static string _user = "root";
        private static string _password = "";

        public static string StrConn
        {
            get
            {
                return $"SERVER={_server}; DATABASE={_dataBase}; PORT=3306; USER={_user}; PASSWORD={_password};";
            }
        }

    }
}
