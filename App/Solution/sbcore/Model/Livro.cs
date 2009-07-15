﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using sbcore.Model.Interface;

namespace sbcore.Model
{
    public class Livro : ISbItem
    {
        #region Atributos e propriedades
        private IList<Capitulo> capitulos;

        public int Numero { get; set; }
        public string Acronimo { get; set; }
        public string Nome { get; set; }
        public Testamento Testamento { get; set; }

        public IList<Capitulo> Capitulos
        {
            get
            {
                return new ReadOnlyCollection<Capitulo>(capitulos);
            }
        }
        #endregion

        #region Construtor
        public Livro(int numero, string acronimo, string nome)
        {
            Numero = numero;
            Acronimo = acronimo;
            Nome = nome;
            capitulos = new List<Capitulo>();
        }
        #endregion

        #region Métodos
        public Capitulo AddCapitulo(Capitulo capitulo)
        {
            capitulo.Livro = this;
            this.capitulos.Add(capitulo);
            return capitulo;
        }
        #endregion

        #region ISbItem Members

        public string Display
        {
            get { return Nome; }
        }

        public IEnumerable<ISbItem> Children
        {
            get { return Enumerable.Cast<ISbItem>(Capitulos); }
        }

        public override string ToString()
        {
            return this.Display;
        }
        #endregion
    }
}
