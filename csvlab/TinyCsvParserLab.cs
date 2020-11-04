using System;
using System.Text;
using TinyCsvParser;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace csvlab
{
    public static class TinyCsvParserLab
    {
        public static void Gerar()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ';');
            CsvBolsaFamiliaMapping csvMapper = new CsvBolsaFamiliaMapping();
            CsvParser<BolsaFamilia> csvParser = new CsvParser<BolsaFamilia>(csvParserOptions, csvMapper);

            var records = csvParser
                .ReadFromFile(@"D:\Projetos\rust\csvlab\202001_BolsaFamilia_Pagamentos.csv", Encoding.UTF8)
                .ToList();

            Console.WriteLine("Total de beneficios: {0}", records.Count());            
        }
    }
}