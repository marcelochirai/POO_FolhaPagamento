using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using POO_FolhaPagamento.Entities;
using System.Threading.Tasks;

namespace POO_FolhaPagamento.Entities
{
    class Terceirizados:Empregados
    {
        public double Adicional { get; set; }

        
        public Terceirizados(string nome, int horas, double adicional, double salario):base (nome, horas,salario)
        {
            Adicional = adicional;
        }

        public double Pagamento()
        {
            return (Salario * Horas) + (Adicional * 1.10);
        }

        public override string ToString()
        {
            return
                Nome +
                " - R$ " + Pagamento().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
