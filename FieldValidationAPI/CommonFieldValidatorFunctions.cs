using System.Text.RegularExpressions;

namespace FieldValidationAPI;

public delegate bool RequiredValidDel(string fieldVal);
public delegate bool StringLengthValidDel(string fieldVal, int min, int max);
public delegate bool DateValidDel(string fieldVal, out DateTime ValidDateTime);
public delegate bool PatternMatchValidDel(string fieldVal, string pattern);
public delegate bool CompareFieldValidDel(string fieldVal, string fieldValCompare);


public class CommonFieldValidatorFunctions
{
    private static RequiredValidDel _requiredValidDel = null;
    private static StringLengthValidDel _stringLengthValidDel = null;
    private static DateValidDel _dateValidDel = null;
    private static PatternMatchValidDel _patternMatchValidDel = null;
    private static CompareFieldValidDel _compareFieldValidDel = null;

    private static bool RequiredValidDel(string fieldVal)
    {
        if (!string.IsNullOrEmpty(fieldVal))
            return true;
        return false;
    }
    private static bool StringLengthValidDel(string fieldVal, int min, int max)
    {
        if (fieldVal.Length >= min && fieldVal.Length <= max)
            return true;
        return false;
    }
    private static bool DateValidDel(string fieldVal, out DateTime ValidDateTime)
    {
        if (DateTime.TryParse(fieldVal,out ValidDateTime))
            return true;
        return false;
    }
    private static bool PatternMatchValidDel(string fieldVal, string regExPattern)
    {
        Regex regex = new Regex(regExPattern);
        if (regex.IsMatch(fieldVal))
            return true;
        return false;
    }
    private static bool CompareFieldValidDel(string fieldVal1, string fieldVal2)
    {
        if (fieldVal1.Equals(fieldVal2))
            return true;
        return false;
    }
}

