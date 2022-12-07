using System.Collections.Generic;

namespace PrimeSifting.Models

{
  public class PrimeSieve
  {
    public int UserInput { get; }

    private List<int> _allNumbers = new List<int> { };

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

    public List<int> RemovePrimeMultiples()
    {
      List<int> container = _allNumbers;
      List<int> container2 = container;
      int i = 0;
      
      while (i < container.Count)
      {
        int prime = container[i];
        for (int i2 = 0; i2 < container.Count; i2++)
        {
          if (container[i2] != prime && container[i2] % prime == 0)
          {
            container2.Remove(container[i2]);
          }
        }
        i++; 
        container = container2; 
      }

      return container;
    }
  }
}


// for (int i = 0; i < _allNumbers.Count; i++)
//       {
//         for (int y = 1; i < _allNumbers.Count; y++)
//         {
//           if(_allNumbers[i] != _allNumbers[y] && _allNumbers[y] % _allNumbers[i] == 0)
//           {
//             _allNumbers.Remove(_allNumbers[y]);
//           }
//         }
//       }