using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
public class Fraction
{
    private int _upper;
    private int _lower;
    
    public Fraction()
    {
        _upper = 1;
        _lower = 1;   
    }

    public Fraction(int wholeNumber)
    {
        _upper = wholeNumber;
        _lower = 1;
    }

    public Fraction(int upper, int lower)
    {
        _upper = upper;
        _lower = lower;
    }

    public void SetUpper(int num)
    {
        _upper = num;
    }

    public int GetUpper()
    {
        return _upper;
    }

    public void SetLower(int num)
    {
        _lower = num;
    }

    public int GetLower()
    {
        return _lower;
    }
    public string GetFractionString(){
        string fractionString = $"{_upper}/{_lower}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double decimalValue = _upper/(double) _lower;
        return decimalValue;
    }

}