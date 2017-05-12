using System;

namespace MateusViegas.GoF.AbstractFactory
{
    public class RG : DocumentoBase
    {
        public string Pai { get; set; }
        public string Mae { get; set; }
        public DateTime DataExpedicao { get; set; }
        public DateTime DataValidade { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string UF { get; set; }
    }
}
