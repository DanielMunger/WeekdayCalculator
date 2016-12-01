using System;
using System.Collections.Generic;
using WeekdayFinder.Objects;
using Xunit;

namespace DateFinderTest
{
  public class DateTest
  {
    [Fact]
    public void DateFormater_Test()
    {
      List<int> result = new List<int> {1, 12, 2000};
      Finder newDate = new Finder("1/12/2000");
      Assert.Equal(result, newDate.ParsedInput());
    }
    [Fact]
    public void DateValue_Test()
    {
      int result = 2;
      Finder newDate = new Finder("1/1/2001");
      Assert.Equal(result, newDate.DateConverter());
    }
  }
}
