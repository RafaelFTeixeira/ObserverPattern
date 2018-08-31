namespace App
{
  public class MockTimeSink : Observer
  {
    public int Hours { get; private set; }
    public int Minutes { get; private set; }
    public int Seconds { get; private set; }
    private TimeSource _source { get; }

    public MockTimeSink(TimeSource source)
    {
      _source = source;
    }

    public void Update()
    {
      Hours = _source.Hours;
      Minutes = _source.Minutes;
      Seconds = _source.Seconds;
    }
  }
}