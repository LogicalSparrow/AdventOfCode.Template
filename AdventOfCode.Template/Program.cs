using AdventOfCode.Template;
using BenchmarkDotNet.Running;

if (args?.Any(a => a.ToLower() == "b" || a.ToLower() == "-b" || a.ToLower().Contains("bench")) == true)
{
    BenchmarkRunner.Run<Benchmarks>();
    return;
}

bool useSample = args?.Any(a => a.ToLower() == "s" || a.ToLower() == "-s" || a.ToLower().Contains("sample")) == true;
long sum = FileProcessor.GetFileAnswer(FileProcessor.GetInputLines(useSample));
Console.WriteLine(sum);