using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode.Template;

[MemoryDiagnoser]
public class Benchmarks
{
    private readonly static string[] _lines = FileProcessor.GetInputLines(); 

    [Benchmark]
    public void GetAnswer()
    {
        _ = FileProcessor.GetFileAnswer(_lines);
    }
}
