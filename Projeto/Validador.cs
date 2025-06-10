using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool DataValidar(string data, string formato = "00/00/0000")
        {
            return DateTime.TryParseExact(
                data,
                formato,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out _);
        }
    }
}
