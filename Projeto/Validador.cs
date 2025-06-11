using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Projeto
{
    public static class Validador
    {
        public static bool EmailValidar(string email)
        {
            return !string.IsNullOrWhiteSpace(email) &&
                email.Contains("@") &&
                email.Contains(".");
        }

        public static bool DataValidar(string data, string formato = "dd/MM/yyyy")
        {
            if (string.IsNullOrWhiteSpace(data))
                return false;

            DateTime resultado;
            return DateTime.TryParseExact(
                data,
                formato,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out resultado
            );
        }
    }
}
