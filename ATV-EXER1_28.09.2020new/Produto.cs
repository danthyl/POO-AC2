using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXERC1_28._09._2020
{
    class Produto
    {
        private string _nome;
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }

        //Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*Definição para nome
        public void SetNome(string nome)
        {
            //Caso o usuário deixe vazio ou apenas um
            //caracter não irá escrever no código
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        //Obteção do nome
        public string GetNome()
        {
            return _nome;
        }

        //Obteção do preço
        public double GetPreco()
        {
            return _preco;
        }

        //Obteção da quantidade
        public int GetQuantidade()
        {
            return _quantidade;
        }*/
    }
}
