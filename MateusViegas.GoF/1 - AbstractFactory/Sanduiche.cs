using System;
using System.Collections.Generic;

namespace MateusViegas.GoF.AbstractFactory
{
    public abstract class Sanduiche
    {
        public string Nome { get; set; }
        private IList<string> _ingredientes = new List<string>();
        public IEnumerable<String> Ingredientes { get { return _ingredientes; } }
        public string Descricao { get { return string.Join(", ", Ingredientes); } }
        public Sanduiche AddIngrediente(string ingrediente)
        {
            if (!_ingredientes.Contains(ingrediente))
                _ingredientes.Add(ingrediente);

            return this;
        }

        public Sanduiche RemoveIngrediente(string ingrediente)
        {
            _ingredientes.Remove(ingrediente);

            return this;
        }
    }
}
