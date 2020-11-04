using BenchmarkDotNet.Attributes;

namespace csvlab
{
    [MemoryDiagnoser]
    public class CsvBenchmarkingLab
    {
        [Benchmark(Baseline = true)]
        public void CSVHelper()
        {
            CsvHelperLab.Gerar<BolsaFamilia>();
        }
        [Benchmark]
        public void TinyCsvParser()
        {
            TinyCsvParserLab.Gerar();
        }
    }
}