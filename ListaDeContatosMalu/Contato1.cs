﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosMalu
{
    internal class Contato
    {
        //declaração de variaveis
        private string nome;
        private string sobrenome;
        private string telefone;

        //propriedades
        //get = leitura
        //set = definiçao
        //é possível ser somente leitura, ou somente definição
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {

            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {

            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = " (00) 00000-0000";
                }
            }
        }
        //construtor da classe
        public Contato()
        {
            Nome = "Claudio";
            sobrenome = "Genésio II";
            Telefone = "(11) 95555-6666";
        }
        //sobrecarga do método
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }

}
