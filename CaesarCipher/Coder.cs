namespace CaesarCipher;
public static class Coder
{
    private static string _alphabet = Alphabet.Alphabets[Alphabet.Language.rus];        

    public static bool ChooseLanguage(string lang)
    {
        if (lang == "rus")
        {
            _alphabet = Alphabet.Alphabets[Alphabet.Language.rus];
            return true;
        }
        else if (lang == "eng")
        {
            _alphabet = Alphabet.Alphabets[Alphabet.Language.eng];
            return true;
        }
        else
        {
            return false;
        }
    }
    public static string Encode (string inputText, int key)
    {
        return TransformText(inputText, key);
    }
    public static string Decode (string inputText, int key)
    {            
        key = -key;            
        return TransformText(inputText, key);
    }

    private static string TransformText(string inputText, int key)
    {
        inputText = inputText.ToLower();
        string outputText = "";
        for (int i = 0; i < inputText.Length; i++)
        {
            int charPosition = _alphabet.IndexOf(inputText[i]);
            if (charPosition != -1)
            {                    
                outputText += _alphabet[CalculateIndex(charPosition + key)];
            }
            else
            {
                outputText += inputText[i];
            }
        }
        return outputText;
    }
    private static int CalculateIndex(int position)
    {
        if (position >= _alphabet.Length)
            return position -_alphabet.Length;
        else if (position < 0)
            return _alphabet.Length + position;
        else
            return position;
    }
}