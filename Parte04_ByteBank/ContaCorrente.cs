﻿using Parte04_ByteBank;
using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public static int ContadorDeSaquesNaoPermitidos { get; private set; }

        public static int ContadorDeTransferenciasNaoPermitidas { get; private set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("A agência não pode ser menor ou igual a zero.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("o número não pode ser menor ou igual a zero.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque, argumento: " + nameof(valor));
            }
            
            if (_saldo < valor)
            {
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferência, argumento: " + nameof(valor));
            }


            try
            {
                Sacar(valor);
            }
            catch (OperacaoFincanceiraException ex)
            {
                ContadorDeTransferenciasNaoPermitidas++;
                throw new OperacaoFincanceiraException("Operação não realizada!", ex);
            }
            
            
            
            contaDestino.Depositar(valor);
            
        }
    }
}
