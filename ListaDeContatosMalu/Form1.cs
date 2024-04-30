﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosMalu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Contato[] listaDeContatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escrever = new StreamWriter("contatos.txt");

            escrever.WriteLine(listaDeContatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < listaDeContatos.Length; x++)
            {
                escrever.WriteLine(listaDeContatos[x].Nome);
                escrever.WriteLine(listaDeContatos[x].Sobrenome);
                escrever.WriteLine(listaDeContatos[x].Telefone);
            }
            escrever.Close();
        }

        private void Ler()
        {
            StreamReader ler = new StreamReader("Contatos.txt");
            listaDeContatos = new Contato[Convert.ToInt32(ler.ReadLine())];


        }
        private void buttonIncluirContato_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxNome.Text;
            contato.Telefone = textBoxNome.Text;

            listBoxContatos.Items.Add(contato.ToString());
        }
    }
}
