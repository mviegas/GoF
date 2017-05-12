using System;

namespace MateusViegas.GoF.AbstractFactory
{
    public abstract class DocumentoBase
    {
        public string NomeCompleto { get; set; }
        public string Numero { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
