using System;

var result = ToneHelper.GetPrefix(Tone.Professional);

Console.WriteLine("--- Тест Empathix ---");
Console.WriteLine("Обраний тон: Професійний");
Console.WriteLine("Префікс для ШІ: " + result);

public enum Tone 
{ 
    Professional, 
    Friendly, 
    Soft 
}

public static class ToneHelper
{
    public static string GetPrefix(Tone tone)
    {
        switch (tone)
        {
            case Tone.Professional:
                return "Dear";
            case Tone.Friendly:
                return "Hi";
            case Tone.Soft:
                return "Hello";
            default:
                return "";
        }
    }
}