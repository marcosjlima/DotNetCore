using System;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;

namespace csvlab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inicio: {0}", System.DateTime.Now.ToLongTimeString());
            //// CsvHelper Lento, mas amigavel para uso
            //CsvHelperLab.Gerar<BolsaFamilia>();
            
            //// TinyCsvParser um pouco mais rapido, menos amigavel para uso
            //TinyCsvParserLab.Gerar();
            //Console.WriteLine("Fim: {0}", System.DateTime.Now.ToLongTimeString());

            var summary = BenchmarkRunner.Run<CsvBenchmarkingLab>();
        }
    }
}
