using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using POO_FolhaPagamento.Entities;

namespace POO_FolhaPagamento.Entities
{
    class Empregados
    {
        public int Horas { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregados(string nome, int horas,  double salario)
        {
            Horas = horas;
            Nome = nome;
            Salario = salario;
        }

        public double SalarioMensal ()
        {
            return Salario = Salario * Horas;
        }

        public override string ToString()
        {
            return Nome
                + " - R$ " 
                + SalarioMensal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
