namespace CaesarCipher;
internal static class Alphabet
{
    internal static Dictionary<Language, string> Alphabets = new Dictionary<Language, string>
    {
       { Language.rus, "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"},
       { Language.eng, "abcdefghijklmnopqrstuvwxyz"},
    };
    public enum Language: byte
    {
        rus,
        eng
    }
}
