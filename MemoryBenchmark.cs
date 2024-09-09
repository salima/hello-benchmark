using BenchmarkDotNet.Attributes;
using System.Text;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class MemoryBenchmark
    {
        int NumeroDeItens = 100;
      
        [Benchmark]
        public string ConcatStringsUsando_StringJoin()
        {
            string result = "";
            for (int i = 0; i < NumeroDeItens; i++)
            {
                result += "SauloLima.com.br " + i;
            }

            return result;
        }

        [Benchmark]
        public string ConcatenandoStringsCom_StringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                sb.Append("SauloLima.com.br " + i);
            }
            return sb.ToString();
        }
    }
}