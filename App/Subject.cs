using System.Collections.Generic;

namespace App
{
  public class Subject
  {
    private List<Observer> _itsObervers = new List<Observer>();

    public void NotifyObservers()
    {
      foreach (var observer in _itsObervers)
        observer.Update();
    }

    public void RegisterObserver(Observer observer)
    {
      _itsObervers.Add(observer);
    }
  }
}