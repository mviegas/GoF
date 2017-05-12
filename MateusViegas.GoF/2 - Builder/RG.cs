using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public class RG
    {
        public string NomeCompleto { get; set; }
        public string Numero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public DateTime DataExpedicao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string UF { get; set; }
    }
}