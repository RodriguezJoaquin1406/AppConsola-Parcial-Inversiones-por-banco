using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_inversiones_por_banco.Negocio
{
    static public class Calculos
    {
        // Hacer funciones que devuelva el monto resultado de cada modalidad de inversion.

        public static decimal CalcularInversionAnual(decimal monto, decimal tasa, int meses)
        {
            //decimal resultado = monto * (1 + (tasa / 100) * meses);
            decimal resultado = 0;
            return resultado;
        }

        public static decimal CalcularInversionTrimestral(decimal monto, decimal tasa, int meses)
        {
            // Recibir tasa dividir entre 4 y multiplicar por el monto y por la cantidad de trimestres (meses / 3)
            decimal resultado = 0;
            return resultado;
        }

        public static decimal CalcularInversionMensual(decimal monto, decimal tasa, int meses)
        {
            //decimal resultado = monto * (1 + (tasa / 100) * meses);
            decimal resultado = 0;
            return resultado;
        }
    }
}
