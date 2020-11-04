using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using System.Linq;

namespace csvlab
{
    public static class CsvHelperLab
    {
        public static void Gerar<T>()
        {
            using (var reader = new StreamReader(@"D:\Projetos\rust\csvlab\202001_BolsaFamilia_Pagamentos.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Configuration.Delimiter = ";";
                    var records = csv.GetRecords<T>().ToHashSet();

                    Console.WriteLine("Total de beneficios: {0}", records.Count());
                }
            }
        }
    }
}