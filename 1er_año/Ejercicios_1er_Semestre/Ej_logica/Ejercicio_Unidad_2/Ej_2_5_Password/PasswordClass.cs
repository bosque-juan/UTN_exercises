using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2_5_Password
{
    internal class PasswordClass
    {
        private string Longitud = "apadf3AS";
        private string Valor = "";

        public string EsFuerte()
        {
            int countMay = Longitud.Count(char.IsUpper);
            int countMin = Longitud.Count(char.IsLower);
            int countNum = Longitud.Count(char.IsDigit);

            bool MasDosMayúsuculas = countMay > 2;
            bool MasDosMinusuculas = countMin > 1;
            bool MasDosNum = countMay > 5;
            string passwordPower = (MasDosMayúsuculas && MasDosMinusuculas && MasDosNum) ? "Es fuerte" : "Es debil";
            return passwordPower;
        }
    }
}
