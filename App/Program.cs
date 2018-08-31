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
      var today = DateTime.Now;
      source.SetTime(today.Hour, today.Minute, today.Second);

      Console.WriteLine($"{sink.Hours}:{sink.Minutes}:{sink.Seconds}");
    }
  }
}
