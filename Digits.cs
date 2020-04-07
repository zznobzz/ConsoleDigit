using ConsoleDigit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Digit : IEnumerable<string>
{
    public Digit(string name)
    {
        Name = name;
    }

    public void AddDigit(string digit)
    {
        _digits.Add(digit);
        _digits.Sort();
    }

    public Statistic GetStatistic()
    {
        var result = new Statistic();
        result.Average = 0;
        result.High = int.MinValue;
        result.Low = int.MaxValue;
        var index = 0;
        foreach (var item in _digits)
        {
            result.High = Math.Max(item.Length, result.High);
            result.Low = Math.Min(item.Length, result.Low);
            result.Average += item.Length;
            index++;
        }
        result.Average /= index;
        result.HighNum  = from item in _digits
                             where item.Length > 0 && item.Length == result.High
                             select item;
        
        result.LowNum = from item in _digits
                        where item.Length > 0 && item.Length == result.Low
                        select item;
        return result;
    }

    private readonly List<string> _digits = new List<string>();

    public string Name { get; }

    public IEnumerator<string> GetEnumerator() => _digits.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
