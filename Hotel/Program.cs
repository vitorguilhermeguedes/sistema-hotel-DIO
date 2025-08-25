﻿using System;
using System.Collections.Generic;
using Hotel.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa("Vitor", "Guedes"),
            new Pessoa("Ana", "Silva")
        };

        Suite suite = new Suite("Premium", 2, 100m);

        Reserva reserva = new Reserva(12);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da reserva: R$ {reserva.CalcularValorDiaria()}");
    }
}
