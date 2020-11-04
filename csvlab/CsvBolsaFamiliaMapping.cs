using System;
using TinyCsvParser.Mapping;

namespace csvlab
{
    public class CsvBolsaFamiliaMapping : CsvMapping<BolsaFamilia>
    {
        public CsvBolsaFamiliaMapping() : base()
        {
            MapProperty(0, x => x.Mesreferencia);
            MapProperty(1, x => x.Mescompetencia);
            MapProperty(2, x => x.Uf);
            MapProperty(3, x => x.Codigomunicipiosiafi);
            MapProperty(4, x => x.Nomemunicipio);
            MapProperty(5, x => x.Cpffavorecido);
            MapProperty(6, x => x.Nisfavorecido);
            MapProperty(7, x => x.Nomefavorecido);
            MapProperty(8, x => x.Valorparcela);
        }
    }
}