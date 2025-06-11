using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DLLEsportes;

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
    }
}
