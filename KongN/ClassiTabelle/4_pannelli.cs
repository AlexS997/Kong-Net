using Dapper.Contrib.Extensions;

namespace KongN.ClassiTabelle
{
    [Table("4_pannelli")]
    public class _4_pannelli
    {
        [ExplicitKey]
        public int iDPannelli { get; set; }
        public string PONTE { get; set; }
        public string PANNELLO { get; set; }
        public string Note { get; set; }
        public int idPonti { get; set; }
        public int Apertura { get; set; }
        public int Distanza { get; set; }
        public int Direzione { get; set; }
        public int Tecnologia { get; set; }
    }
}
