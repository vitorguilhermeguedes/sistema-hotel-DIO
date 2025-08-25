using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; }
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite != null && hospedes.Count > Suite.Capacidade)
                throw new Exception("Quantidade de hóspedes excede a capacidade da suíte.");

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
                valor *= 0.9m; // aplica 10% de desconto

            return valor;
        }
    }
}
