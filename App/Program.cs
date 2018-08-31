using System;

namespace App
{
  class Program
  {
    static void Main(string[] args)
    {
      var source = new MockTimeSource();
      var sink = new MockTimeSink(source);
      source.RegisterObserver(sink);
      source.SetTime(1, 2, 2);

      Console.WriteLine($"{source.Hours}:{source.Minutes}:{source.Seconds}");
      Console.WriteLine($"{sink.Hours}:{sink.Minutes}:{sink.Seconds}");
    }
  }
}
