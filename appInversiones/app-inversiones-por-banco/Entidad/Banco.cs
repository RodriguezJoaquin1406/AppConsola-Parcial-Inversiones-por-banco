using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_inversiones_por_banco.Entidad
{
    internal class Banco
    {
        private string nombre;
        private decimal[] tasas = new decimal[3];

        private decimal ObtenerPromedioTasas() {
            decimal ejemplo = 0;

            for (int i = 0; i < tasas.Length; i++)
            {
                ejemplo += tasas[i];
            }

            ejemplo /= tasas.Length;

            return ejemplo;
        }
    }
}
