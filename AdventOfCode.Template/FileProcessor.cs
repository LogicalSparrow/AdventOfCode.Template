namespace AdventOfCode.Template;

public partial class FileProcessor
{
    const string FileName = "input.txt";
    const string SampleFileName = "sample.txt";
    const int _batchSize = 50;    

    public static long GetFileAnswer(string[] lines)
    {
        long answer = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            answer++; //TODO
        }
        return answer;
    }

    //public static long GetFileAnswerParallel(string[] lines)
    //{
    //    ConcurrentBag<long> answers = [];
    //    Parallel.ForEach(Enumerable.Range(0, lines.Length / _batchSize), new ParallelOptions { MaxDegreeOfParallelism = 20 }, (batchIndex, state, index) =>
    //    {
    //        long answer = 0;
    //        foreach (string line in lines.Skip(batchIndex * _batchSize).Take(_batchSize))
    //        {
    //            answer++;//TODO
    //        }
    //        answers.Add(sum);
    //        return;
    //    });
    //    return answers.Sum();
    //}

    public static string[] GetInputLines(bool useSample = false)
    {
        FileInfo fileInfo = new(useSample ? SampleFileName : FileName);
        using FileStream fileStream = fileInfo.OpenRead();
        using StreamReader reader = new(fileStream);
        string[] lines = reader.ReadToEnd().Split("\n", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        return lines;
        //string? line;
        //while ((line = reader.ReadLine()) != null)
        //{
        //    yield return line;
        //}
    }
}
