using System.Collections.Generic;

namespace PrimeSifting.Models

{
  public class PrimeSieve
  {
    public int UserInput { get; }

    private List<int> _allNumbers = new List<int>{};

    public PrimeSieve(int userInput)
    {
      UserInput = userInput;
      SetAllNumbers();
    }

    public void SetAllNumbers()
    {
      for (int i = 2; i <= UserInput; i++)
      {
        _allNumbers.Add(i);
      }
    }

    public List<int> GetAllNumbers()
    {
      return _allNumbers;
    }
  }
}