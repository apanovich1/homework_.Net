public class SunLoungers
{
    static void Main()
    {
        string sunLongers = "0";
        Console.WriteLine(GetFreeLounger(sunLongers).ToString());
    }
    public static int GetFreeLounger(string sunLongers)
    {
        int freeLongers = 0;
        var allSunLongers = sunLongers.ToCharArray();
        int place = 0;
        for (place = 0; place < allSunLongers.Length; place++)
        {
            if (place == 1 && sunLongers.Contains("0"))
            {
                freeLongers = 1;
                return freeLongers;
            }
            if (place == 3 && sunLongers.Contains("000"))
            {
                freeLongers = 2;
                return freeLongers;
            }
            foreach (var freeLonger in sunLongers)
            {
                if (sunLongers.Contains("00"))
                {
                    freeLongers++;
                    return freeLongers;
                }
            }
        }
        return freeLongers;
    }

}
/*  {
      int freeLongers = 0;
      if (sunLongers.Contains("0"))
      {
          freeLongers = 1;
          return freeLongers;
      }
      if (sunLongers.Contains("000"))
      {
          freeLongers = 2;
          return freeLongers;
      }
      foreach (var freeLonger in sunLongers)
      {
          if (sunLongers.Contains("00"))
          {
              freeLongers += 1;
          }
      }
      return freeLongers;

  }
}*/